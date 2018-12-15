﻿namespace Net.Torrent.Tracker.Common.Test
{
    public static class SharedData
    {

        public static readonly byte[] ConnectRequest = new byte[]
        {
            // protocol id
            0x00, 0x00, 0x04, 0x17, 0x27, 0x10, 0x19, 0x80,
            // action id
            0x00, 0x00, 0x00, 0x00,
            // transaction id
            0x00, 0x00, 0x00, 0x6f,
        };

        public static readonly byte[] AnnounceRequest = new byte[]
        {
            // 0 connection id
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xfa, 0xff,
            // 8 action = 1
            0x00, 0x00, 0x00, 0x01,
            // 12 transaction
            0x00, 0x00, 0xff, 0xff,
            // 16 info hash
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xfb, 0xff,
            // 36 peer id
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xfc, 0xff,
            // 56 downloaded
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            // 64 left
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            // 72 uploaded
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            // 80 event (2)
            0x00, 0x00, 0x00, 0x02,
            // 84 ip addr
            0x00, 0x00, 0x00, 0x00,
            // 88 key
            0x00, 0x00, 0x00, 0x00,
            // 92 num want
            0x00, 0x00, 0x00, 0xc8,
            // 98 port
            0xb2, 0x68
        };

        public static readonly byte[] ScrapeRequest = new byte[]
        {
            // connection id
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xfa, 0xff,
            // action
            0x00, 0x00, 0x00, 0x02,
            // transaction
            0x00, 0x00, 0x00, 0xff,
            // hash1
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xfa, 0xff,
            // hash2
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xdd, 0xee
        };

        public static readonly byte[] ConnectResponse = new byte[]
        {
            // action  - connect 0
            0x00, 0x00, 0x00, 0x00,
            // tran id
            0x00, 0x00, 0x00, 0x7f,
            // connection id
            0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x6f
        };

        public static readonly byte[] AnnounceResponse = new byte[]
        {
            // action
            0x00, 0x00, 0x00, 0x01,
            // transaction
            0x00, 0x00, 0x00, 0xff,
            // interval
            0x00, 0x00, 0x06, 0xa8,
            // leechers
            0x00, 0x00, 0x00, 0x01,
            // seeders
            0x00, 0x00, 0x00, 0xfa,
            // ip addr
            0x03, 0x01, 0xa8, 0xc0,
            // port
            0x00, 0xfa,
            // ip addr
            0x06, 0x01, 0xa8, 0xc0,
            // port
            0x00, 0xfa
        };

        public static readonly byte[] ScrapeResponse = new byte[]
        {
            // action
            0x00, 0x00, 0x00, 0x02,
            // transaction
            0x00, 0x00, 0xfa, 0xff,
            // seeders
            0x00, 0x00, 0x00, 0x05,
            // completed
            0x00, 0x00, 0x00, 0x06,
            // leechers
            0x00, 0x00, 0x00, 0x07
        };

        public static readonly byte[] ErrorResponse = new byte[]
        {
            // action - error
            0x00, 0x00, 0x00, 0x03,
            //transaction 
            0x00, 0x00, 0x00, 0xfa,
            // string 'some text'
            0x73, 0x6f, 0x6d, 0x65, 0x20, 0x74, 0x65, 0x78, 0x74
        };
    }
}
