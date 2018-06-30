---
layout: page
title: Examples
menu_order: 5
menu:
---


This is a part of the Test/Example.proto:

	package ExampleNamespace;
	
	message Person {
	  option namespace = "Personal";
	  
	  required string name = 1;
	  required int32 id = 2;
	  optional string email = 3;
	
	  enum PhoneType {
	    MOBILE = 0;
	    HOME = 1;
	    WORK = 2;
	  }
	
	  message PhoneNumber {
	    required string number = 1;
	    optional PhoneType type = 2 [default = HOME];
	  }
	
	  repeated PhoneNumber phone = 4;
	}

When compiled it you will have the following class to work with.

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

Writing this to a stream:

	Person person = new Person();
	...
	Person.Serialize(stream, person);

Reading from a stream:

	Person person2 = Person.Deserialize(stream);

## Usage

    CodeGenerator.exe Example.proto [output.cs]

If the optional output.cs parameter is omitted it will default to the basename of the .proto file.
In this example it would be Example.cs

The output is:

 * Example.cs - Class declaration(based on .proto).
 * Example.Serializer.cs - Code for reading/writing the messages.
 * ProtocolParser.cs - Helper functions for reading and writing the protobuf wire format, not related to the contents of your .proto.

If you generate code from multiple .proto files you must only include ProtocolParser.cs once in your project.
