// THIS FILE WAS AUTO-GENERATED BY ADKGEN -- DO NOT MODIFY!

//
// Copyright (c)1998-2011 Pearson Education, Inc. or its affiliate(s).
// All rights reserved.
//

using System;
using System.Text;
using System.Security.Permissions;
using System.Runtime.Serialization;
using OpenADK.Library;
using OpenADK.Library.Global;
using OpenADK.Library.au.Common;

namespace OpenADK.Library.au.Student{

/// <summary>A RoomInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class RoomInfo : SifDataObject
{
	/// <summary>
	/// Creates an instance of a RoomInfo
	/// </summary>
	public RoomInfo() : base( Adk.SifVersion, StudentDTD.ROOMINFO ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">GUID that identifies this room.</param>
	///<param name="schoolInfoRefId">GUID that identifies the school that this room belongs to.</param>
	///<param name="roomNumber">Room number as presented to the user/application.</param>
	///
	public RoomInfo( string refId, string schoolInfoRefId, string roomNumber ) : base( Adk.SifVersion, StudentDTD.ROOMINFO )
	{
		this.RefId = refId;
		this.SchoolInfoRefId = schoolInfoRefId;
		this.RoomNumber = roomNumber;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected RoomInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { StudentDTD.ROOMINFO_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID that identifies this room."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.ROOMINFO_REFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ROOMINFO_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SchoolInfoRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>SchoolInfoRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "GUID that identifies the school that this room belongs to."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string SchoolInfoRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.ROOMINFO_SCHOOLINFOREFID ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ROOMINFO_SCHOOLINFOREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RoomNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>RoomNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Room number as presented to the user/application."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string RoomNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.ROOMINFO_ROOMNUMBER ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ROOMINFO_ROOMNUMBER, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;StaffList&gt;</c> element.</summary>
	/// <param name="StaffPersonalRefId">GUID that identifies the staff person assigned to this room (e.g. the homeroom teacher).</param>
	///<remarks>
	/// <para>This form of <c>setStaffList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>StaffList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetStaffList( StaffPersonalRefId StaffPersonalRefId ) {
		RemoveChild( StudentDTD.ROOMINFO_STAFFLIST);
		AddChild( StudentDTD.ROOMINFO_STAFFLIST, new StaffList( StaffPersonalRefId ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;StaffList&gt;</c> element.
	/// </summary>
	/// <value> A StaffList </value>
	/// <remarks>
	/// <para>To remove the <c>StaffList</c>, set <c>StaffList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public StaffList StaffList
	{
		get
		{
			return (StaffList)GetChild( StudentDTD.ROOMINFO_STAFFLIST);
		}
		set
		{
			RemoveChild( StudentDTD.ROOMINFO_STAFFLIST);
			if( value != null)
			{
				AddChild( StudentDTD.ROOMINFO_STAFFLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Friendly name that can be assigned to the room (e.g. Staff Cafeteria)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.ROOMINFO_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ROOMINFO_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Building&gt;</c> element.
	/// </summary>
	/// <value> The <c>Building</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Extra building information. In the future Building could become its own object in which case this element will need to be changed to a RefId. Currently it is only required as a free text field."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Building
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.ROOMINFO_BUILDING ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ROOMINFO_BUILDING, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;HomeroomNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>HomeroomNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "When a room is designated as a homeroom it may have a different number. Usually blank when room is not a homeroom."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string HomeroomNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( StudentDTD.ROOMINFO_HOMEROOMNUMBER ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ROOMINFO_HOMEROOMNUMBER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Size&gt;</c> element.
	/// </summary>
	/// <value> The <c>Size</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Size in square meters."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public decimal? Size
	{
		get
		{
			return (decimal?) GetSifSimpleFieldValue( StudentDTD.ROOMINFO_SIZE ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ROOMINFO_SIZE, new SifDecimal( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Capacity&gt;</c> element.
	/// </summary>
	/// <value> The <c>Capacity</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Number of persons (usually students) that this room can hold."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public int? Capacity
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( StudentDTD.ROOMINFO_CAPACITY ) ;
		}
		set
		{
			SetFieldValue( StudentDTD.ROOMINFO_CAPACITY, new SifInt( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;PhoneNumber&gt;</c> element.</summary>
	/// <param name="Type">
	/// Code that specifies what type of phone number this is.
	/// Note: A subset of valid values may be specified in data
	/// objects.</param>
	/// <param name="Number">
	/// Phone number. Free-form, but typical U.S. formats
	/// include:</param>
	///<remarks>
	/// <para>This form of <c>setPhoneNumber</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PhoneNumber</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPhoneNumber( PhoneNumberType Type, string Number ) {
		RemoveChild( StudentDTD.ROOMINFO_PHONENUMBER);
		AddChild( StudentDTD.ROOMINFO_PHONENUMBER, new PhoneNumber( Type, Number ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PhoneNumber&gt;</c> element.
	/// </summary>
	/// <value> A PhoneNumber </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Phone number for the room"</para>
	/// <para>To remove the <c>PhoneNumber</c>, set <c>PhoneNumber</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public PhoneNumber PhoneNumber
	{
		get
		{
			return (PhoneNumber)GetChild( StudentDTD.ROOMINFO_PHONENUMBER);
		}
		set
		{
			RemoveChild( StudentDTD.ROOMINFO_PHONENUMBER);
			if( value != null)
			{
				AddChild( StudentDTD.ROOMINFO_PHONENUMBER, value );
			}
		}
	}

}}
