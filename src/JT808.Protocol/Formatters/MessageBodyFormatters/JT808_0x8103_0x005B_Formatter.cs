﻿using JT808.Protocol.Extensions;
using JT808.Protocol.Interfaces;
using JT808.Protocol.MessageBody;
using System;

namespace JT808.Protocol.Formatters.MessageBodyFormatters
{
    public class JT808_0x8103_0x005B_Formatter : IJT808Formatter<JT808_0x8103_0x005B>
    {
        public JT808_0x8103_0x005B Deserialize(ReadOnlySpan<byte> bytes, out int readSize, IJT808Config config)
        {
            int offset = 0;
            JT808_0x8103_0x005B jT808_0x8103_0x005B = new JT808_0x8103_0x005B
            {
                ParamLength = JT808BinaryExtensions.ReadByteLittle(bytes, ref offset),
                ParamValue = JT808BinaryExtensions.ReadUInt16Little(bytes, ref offset)
            };
            readSize = offset;
            return jT808_0x8103_0x005B;
        }

        public int Serialize(ref byte[] bytes, int offset, JT808_0x8103_0x005B value, IJT808Config config)
        {
            offset += JT808BinaryExtensions.WriteByteLittle(bytes, offset, value.ParamLength);
            offset += JT808BinaryExtensions.WriteUInt16Little(bytes, offset, value.ParamValue);
            return offset;
        }
    }
}
