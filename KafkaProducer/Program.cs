using Confluent.Kafka;

namespace KafkaProducer
{
    class Program
    {
        public static async Task Main()
        {
            var config = new ProducerConfig { 
                BootstrapServers = "sulky.srvs.cloudkafka.com:9094",
                SaslUsername = "pahgpgwu",                 
                SaslPassword = "kBLow9zHco2bD7uO7UQYn0dVe14L7cdl",
                SaslMechanism = SaslMechanism.ScramSha512,
                SecurityProtocol = SecurityProtocol.SaslSsl,
                EnableSslCertificateVerification = false
            
            };

            using var p = new ProducerBuilder<Null, string>(config).Build();

            {
                try
                {
                    var count = 0;
                    while (true)
                    {
                        var dr = await p.ProduceAsync("pahgpgwu-default",
                            new Message<Null, string> { Value = $"test: {count++}" });

                        Console.WriteLine($"Delivered '{dr.Value}' to '{dr.TopicPartitionOffset} | {count}'");

                        Thread.Sleep(2000);
                    }
                }
                catch (ProduceException<Null, string> e)
                {
                    Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                }
            }
        }
    }
}