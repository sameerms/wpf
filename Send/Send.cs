using System;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Send
{
    class Send
    {
        public static void Main()
        {

            string senderUniqueId = "userInsertMsgQ";
            var factory = new ConnectionFactory { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "userInsertMsgQ",
                                        durable: false,
                                        exclusive: false,
                                        autoDelete: false,
                                        arguments: null);

                    Console.WriteLine("prese enter to send the list");
                    Console.ReadLine();
                    // create serialize object to send
                    UserService _userService = new UserService();
                    List<User> objectUserList = _userService.GetAllUsersToSend();


                    string message = JsonConvert.SerializeObject(objectUserList);
                    var body = Encoding.UTF8.GetBytes(message);

                    IBasicProperties properties = channel.CreateBasicProperties();
                    properties.Persistent = true;
                    properties.DeliveryMode = 2;
                    properties.Headers = new Dictionary<String, object>();
                    properties.Headers.Add("senderUniqueId", senderUniqueId);

                    channel.ConfirmSelect();

                    channel.BasicPublish(exchange: "",
                        routingKey: "userInsertMsgQ",
                        basicProperties: properties,
                        body: body);
                    channel.WaitForConfirmsOrDie();
                    channel.BasicAcks += (sender, eventArgs) =>
                    {
                        Console.WriteLine(" [x] Sent {0}", message);
                    };

                    channel.ConfirmSelect();
                }
                


            }
        }
    }

