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
using OpenADK.Library.us.Common;

namespace OpenADK.Library.us.Instr{

/// <summary>This object contains personal information about individuals to allow them to be tracked and information collected in role specific objects (e.g., StudentPersonal and StaffPersonal) to be related. In a future major release, the architecture may allow this to be streamlined..</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.6</para>
/// </remarks>
[Serializable]
public class Person : SifDataObject
{
	/// <summary>
	/// Creates an instance of a Person
	/// </summary>
	public Person() : base( Adk.SifVersion, InstrDTD.PERSON ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">The RefId of the PersonRoleAssociation object.</param>
	///<param name="personRefId">The GUID of the person.</param>
	///<param name="associatedRoleRefId">The RefId of the *Personal SIF_Object representing this Person's role .</param>
	///<param name="entryDate">Effective start date of the association.</param>
	///<param name="exitDate">Effective end date of the association.</param>
	///<param name="authoritativeSource">Body or organization creating this association.</param>
	///
	public Person( string refId, string personRefId, AssociatedRoleRefId associatedRoleRefId, DateTime? entryDate, DateTime? exitDate, string authoritativeSource ) : base( Adk.SifVersion, InstrDTD.PERSON )
	{
		this.RefId = refId;
		this.PersonRefId = personRefId;
		this.AssociatedRoleRefId = associatedRoleRefId;
		this.EntryDate = entryDate;
		this.ExitDate = exitDate;
		this.AuthoritativeSource = authoritativeSource;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Person( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { InstrDTD.PERSON_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "The RefId of the PersonRoleAssociation object."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.PERSON_REFID ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.PERSON_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PersonRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>PersonRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The GUID of the person."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string PersonRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.PERSON_PERSONREFID ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.PERSON_PERSONREFID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;AssociatedRoleRefId&gt;</c> element.</summary>
	/// <param name="Type">The object type of the Person's associated role.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;AssociatedRoleRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setAssociatedRoleRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>AssociatedRoleRefId</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetAssociatedRoleRefId( TypeRole Type, string Value ) {
		RemoveChild( InstrDTD.PERSON_ASSOCIATEDROLEREFID);
		AddChild( InstrDTD.PERSON_ASSOCIATEDROLEREFID, new AssociatedRoleRefId( Type, Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AssociatedRoleRefId&gt;</c> element.
	/// </summary>
	/// <value> An AssociatedRoleRefId </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "The RefId of the *Personal SIF_Object representing this Person's role ."</para>
	/// <para>To remove the <c>AssociatedRoleRefId</c>, set <c>AssociatedRoleRefId</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public AssociatedRoleRefId AssociatedRoleRefId
	{
		get
		{
			return (AssociatedRoleRefId)GetChild( InstrDTD.PERSON_ASSOCIATEDROLEREFID);
		}
		set
		{
			RemoveChild( InstrDTD.PERSON_ASSOCIATEDROLEREFID);
			if( value != null)
			{
				AddChild( InstrDTD.PERSON_ASSOCIATEDROLEREFID, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;EntryDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>EntryDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Effective start date of the association."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? EntryDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( InstrDTD.PERSON_ENTRYDATE ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.PERSON_ENTRYDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;ExitDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>ExitDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Effective end date of the association."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? ExitDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( InstrDTD.PERSON_EXITDATE ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.PERSON_EXITDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AuthoritativeSource&gt;</c> element.
	/// </summary>
	/// <value> The <c>AuthoritativeSource</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Body or organization creating this association."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public string AuthoritativeSource
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InstrDTD.PERSON_AUTHORITATIVESOURCE ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.PERSON_AUTHORITATIVESOURCE, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;Creator&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;CreatorPerson&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setCreator</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>Creator</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public void SetCreator( string Value ) {
		RemoveChild( InstrDTD.PERSON_CREATOR);
		AddChild( InstrDTD.PERSON_CREATOR, new CreatorPerson( Value ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Creator&gt;</c> element.
	/// </summary>
	/// <value> A CreatorPerson </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Name of the Creator of this association."</para>
	/// <para>To remove the <c>CreatorPerson</c>, set <c>Creator</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public CreatorPerson Creator
	{
		get
		{
			return (CreatorPerson)GetChild( InstrDTD.PERSON_CREATOR);
		}
		set
		{
			RemoveChild( InstrDTD.PERSON_CREATOR);
			if( value != null)
			{
				AddChild( InstrDTD.PERSON_CREATOR, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CreationDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>CreationDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Creation date of the relationship"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.6</para>
	/// </remarks>
	public DateTime? CreationDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( InstrDTD.PERSON_CREATIONDATE ) ;
		}
		set
		{
			SetFieldValue( InstrDTD.PERSON_CREATIONDATE, new SifDate( value ), value );
		}
	}

}}
