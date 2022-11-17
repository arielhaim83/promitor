﻿namespace Promitor.Integrations.Sinks.Statsd.Configuration
{
    public class StatsdSinkConfiguration
    {
        public string Host { get; set; }
        public int Port { get; set; } = 8125;
        public string MetricPrefix { get; set; }
        public string MetricFormat { get; set; } = StatsdFormatterTypes.DEFAULT;
        public GenevaConfiguration Geneva { get; set; }
    }
}