﻿// 
// You may customize this code as you like
// Report bugs to: https://silentorbit.com/protobuf/
// 
// Generated by ProtocolBuffer
//  - a pure c# code generation implementation of protocol buffers
// 
using System;
using System.Collections.Generic;

namespace Personal
{
    public partial class Person
    {
        public enum PhoneType
        {
            MOBILE = 0,
            HOME = 1,
            WORK = 2,
        }

        public string Name { get; set; }

        public int Id { get; set; }

        public string Email { get; set; }

        public List<Personal.Person.PhoneNumber> Phone { get; set; }

        public partial class PhoneNumber
        {
            public string Number { get; set; }

            public Personal.Person.PhoneType Type { get; set; }

        }

    }
}
namespace ExampleNamespaceA
{
    public partial class AddressBook
    {
        public List<Personal.Person> List { get; set; }

    }
}
namespace Mine
{
    /// <summary>
    /// <para>This will be ignored</para>
    /// <para>This class is documented here:</para>
    /// <para>With multiple lines</para>
    /// </summary>
    public partial class MyMessageV1
    {
        /// <summary>This field is important to comment as we just did here</summary>
        public int FieldA { get; set; }

        /// <summary>Values for unknown fields.</summary>
        public List<ProtocolBuffers.KeyValue> PreservedFields;

    }
}
namespace Yours
{
    public partial class MyMessageV2
    {
        public enum MyEnum
        {
            /// <summary>First test</summary>
            ETest1 = 0,
            /// <summary>Second test</summary>
            ETest2 = 3,
            ETest3 = 2,
        }

        public int FieldA { get; set; }

        public double FieldB { get; set; }

        public float FieldC { get; set; }

        public int FieldD { get; set; }

        public long FieldE { get; set; }

        public uint FieldF { get; set; }

        public ulong FieldG { get; set; }

        public int FieldH { get; set; }

        public long FieldI { get; set; }

        public uint FieldJ { get; set; }

        public ulong FieldK { get; set; }

        public int FieldL { get; set; }

        public long FieldM { get; set; }

        public bool FieldN { get; set; }

        public string FieldO { get; set; }

        public byte[] FieldP { get; set; }

        public Yours.MyMessageV2.MyEnum FieldQ { get; set; }

        public Yours.MyMessageV2.MyEnum FieldR { get; set; }

        protected string Dummy { get; set; }

        public List<uint> FieldS { get; set; }

        public List<uint> FieldT { get; set; }

        public Theirs.TheirMessage FieldU { get; set; }

        public List<Theirs.TheirMessage> FieldV { get; set; }

    }
}
namespace Local
{
    /// <summary>This is a demonstration of features only present in ProtoBuf Code Generator</summary>
    internal partial class LocalFeatures
    {
        /// <summary>Make class field of type TimeSpan, serialized to Ticks</summary>
        public TimeSpan Uptime { get; set; }

        /// <summary>Make class field of type DateTime, serialized to Ticks</summary>
        public DateTime DueDate { get; set; }

        //public double Amount { get; set; } //Implemented by user elsewhere
        /// <summary>Custom field access types. Default: public</summary>
        private string Denial { get; set; }

        protected string Secret { get; set; }

        internal string Internal { get; set; }

        public string PR { get; set; }

        /// <summary>Generate a c# readonly field</summary>
        public readonly Mine.MyMessageV1 TestingReadOnly = new Mine.MyMessageV1();

        /// <summary>Values for unknown fields.</summary>
        public List<ProtocolBuffers.KeyValue> PreservedFields;

        // protected virtual void BeforeSerialize() {}
        // protected virtual void AfterDeserialize() {}

    }
}
