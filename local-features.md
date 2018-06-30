---
layout: page
title: Local Advanced Features
menu_order: 6
menu:
  title: Local Features
---


These features are local to this project.
They affect how you will work with the generated code.
The final wire format is not affected.
Any other Protocol Buffers implementation will be able to communicate using the same .proto specification.

Settings for the local features are special comments in the .proto file.
They are set by a comment before the message or field starting with ":". 

All the local features are implemented in the Test project, see Test/ProtoSpec/LocalFeatures.proto .

Message options:

 * access - set the acces of the generated class to internal rather than public.
 * triggers - (flag)have the class methods BeforeSerialize and AfterDeserialize called accordingly.
 * preserverunknown - (flag)keep all unknown fields during deserialization to be written back when serializing the class.
 * external - (flag)generate serialization code for a class we don't have control over, such as one from a third party DLL.
 * type - default: class, but you can make the serializer work with struct or interfaces.

Field options:

 * access - default: public, can be any, even private if generating a local class(default)
 * codetype - set a 64 bit field type to "DateTime" or "TimeSpan", the serialized value is the DateTime.Ticks which is the number of 100-nanoseconds since January the 1:st year 0001, the serializer will do the conversion for you.
 * external - (flag)the field/property is expected to be defined elsewhere in the project rather than the generated code.
 * readonly - (flag)make the message field a c# readonly field rather than a property.

## Example

This example includes all the local features at once as they would be added to a .proto file

	//Documentation of the Test class
	//:access=private //public(default) or internal
	//:triggers
	//:preserverunknown
	//:external
	//:type=struct //class(default), struct or interface
	message Test {
		//Documentation of the FieldTest property
		//:access=private //public(default), internal, protected or private
		//:codetype=DateTime // or TimeSpan, default:none
		//:external
		//:readonly
		required int32 FieldTest = 1;
	...

