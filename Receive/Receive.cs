using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;

namespace Receive
{
    public class Receive    {
        public static void Main()
        {

            string senderUniqueId = "userInsertMsgQ";
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "userInsertMsgQ_feedback",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);
                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {
                        //IDictionary<string, object> headers = ea.BasicProperties.Headers;//getting headers form Received msg

                        //foreach (KeyValuePair<string, object> header in headers)
                        //{
                        //    if (senderUniqueId == Encoding.UTF8.GetString((byte[])header.Value))
                        //    {
                        //        var body = ea.Body;
                        //        var message = Encoding.UTF8.GetString(body);
                        //        UserSaveFeedback feedback = JsonConvert.DeserializeObject<UserSaveFeedback>(message);
                        //        Console.WriteLine(" [x] Received {0}", message);
                        //        Console.WriteLine(" [x] Success count {0} and failed count{1}", feedback.successCount, feedback.failedCount);
                        //    }
                        //}

                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        Console.WriteLine(" [x] Received {0}", message);

                    };
                    channel.BasicConsume(queue: "userInsertMsgQ_feedback",
                            autoAck: true,
                            consumer: consumer);

                    Console.WriteLine(" Press [enter] to exit.");
                    Console.ReadLine();
                }
            }

        }
    }

