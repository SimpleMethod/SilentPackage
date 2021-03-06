﻿/*
 * Copyright  Michał Młodawski (SimpleMethod)(c) 2020.
 */

namespace SilentPackage.Models
{
    public class ReportsModel
    {
        public ReportsModel(int id, long timestamp, string path, string deviceId, string license)
        {
            Id = id;
            Timestamp = timestamp;
            Path = path;
            DeviceId = deviceId;
            License = license;
        }

        public int Id { get; set; }
        public long Timestamp { get; set; }
        public string Path { get; set; }
        public string DeviceId { get; set; }
        public string License { get; set; }
    }
}
