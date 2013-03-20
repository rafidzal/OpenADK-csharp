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
using OpenADK.Library.uk.Common;

namespace OpenADK.Library.uk.Workforce{

/// <summary>This object contains key personal information relating to a workforce member, who might be a teacher or other employee of the school or LA.  Compare with US/Canada objects: EmployeePersonal and StaffPersonal</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class WorkforcePersonal : SifDataObject
{
	/// <summary>
	/// Creates an instance of a WorkforcePersonal
	/// </summary>
	public WorkforcePersonal() : base( Adk.SifVersion, WorkforceDTD.WORKFORCEPERSONAL ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">Note that the same GUID may be assigned to this person when they are also a learner (via LearnerPersonal) and/or a contact (via ContactPersonal).</param>
	///<param name="localId">The locally-assigned identifier for this workforce member.</param>
	///<param name="personalInformation">Personal name, demographic, address, email, and phone information for this person. CBDS: Mulitple</param>
	///
	public WorkforcePersonal( string refId, string localId, PersonalInformation personalInformation ) : base( Adk.SifVersion, WorkforceDTD.WORKFORCEPERSONAL )
	{
		this.RefId = refId;
		this.LocalId = localId;
		this.PersonalInformation = personalInformation;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected WorkforcePersonal( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { WorkforceDTD.WORKFORCEPERSONAL_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "Note that the same GUID may be assigned to this person when they are also a learner (via LearnerPersonal) and/or a contact (via ContactPersonal)."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( WorkforceDTD.WORKFORCEPERSONAL_REFID ) ;
		}
		set
		{
			SetFieldValue( WorkforceDTD.WORKFORCEPERSONAL_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LocalId&gt;</c> element.
	/// </summary>
	/// <value> The <c>LocalId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The locally-assigned identifier for this workforce member."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string LocalId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( WorkforceDTD.WORKFORCEPERSONAL_LOCALID ) ;
		}
		set
		{
			SetFieldValue( WorkforceDTD.WORKFORCEPERSONAL_LOCALID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AlertMsgList&gt;</c> element.
	/// </summary>
	/// <value> An AlertMsgList </value>
	/// <remarks>
	/// <para>To remove the <c>AlertMsgList</c>, set <c>AlertMsgList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public AlertMsgList AlertMsgList
	{
		get
		{
			return (AlertMsgList)GetChild( WorkforceDTD.WORKFORCEPERSONAL_ALERTMSGLIST);
		}
		set
		{
			RemoveChild( WorkforceDTD.WORKFORCEPERSONAL_ALERTMSGLIST);
			if( value != null)
			{
				AddChild( WorkforceDTD.WORKFORCEPERSONAL_ALERTMSGLIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;MedicalAlertMsgList&gt;</c> element.
	/// </summary>
	/// <value> A MedicalAlertMsgList </value>
	/// <remarks>
	/// <para>To remove the <c>MedicalAlertMsgList</c>, set <c>MedicalAlertMsgList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public MedicalAlertMsgList MedicalAlertMsgList
	{
		get
		{
			return (MedicalAlertMsgList)GetChild( WorkforceDTD.WORKFORCEPERSONAL_MEDICALALERTMSGLIST);
		}
		set
		{
			RemoveChild( WorkforceDTD.WORKFORCEPERSONAL_MEDICALALERTMSGLIST);
			if( value != null)
			{
				AddChild( WorkforceDTD.WORKFORCEPERSONAL_MEDICALALERTMSGLIST, value );
			}
		}
	}

	///<summary>Sets the value of the <c>&lt;PersonalInformation&gt;</c> element.</summary>
	/// <param name="Name">Name information for this person. CBDS: Multiple</param>
	///<remarks>
	/// <para>This form of <c>setPersonalInformation</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>PersonalInformation</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetPersonalInformation( Name Name ) {
		RemoveChild( WorkforceDTD.WORKFORCEPERSONAL_PERSONALINFORMATION);
		AddChild( WorkforceDTD.WORKFORCEPERSONAL_PERSONALINFORMATION, new PersonalInformation( Name ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;PersonalInformation&gt;</c> element.
	/// </summary>
	/// <value> A PersonalInformation </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "Personal name, demographic, address, email, and phone information for this person. CBDS: Mulitple"</para>
	/// <para>To remove the <c>PersonalInformation</c>, set <c>PersonalInformation</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public PersonalInformation PersonalInformation
	{
		get
		{
			return (PersonalInformation)GetChild( WorkforceDTD.WORKFORCEPERSONAL_PERSONALINFORMATION);
		}
		set
		{
			RemoveChild( WorkforceDTD.WORKFORCEPERSONAL_PERSONALINFORMATION);
			if( value != null)
			{
				AddChild( WorkforceDTD.WORKFORCEPERSONAL_PERSONALINFORMATION, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;TeacherNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>TeacherNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "The DfES Teacher Reference number. For those who have one this is a unique number. CBDS: 400014"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string TeacherNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( WorkforceDTD.WORKFORCEPERSONAL_TEACHERNUMBER ) ;
		}
		set
		{
			SetFieldValue( WorkforceDTD.WORKFORCEPERSONAL_TEACHERNUMBER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;NINumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>NINumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "National Insurance Number. Do not specify temporary numbers. Format:  AAnnnnnnA CBDS: 400013"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public string NINumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( WorkforceDTD.WORKFORCEPERSONAL_NINUMBER ) ;
		}
		set
		{
			SetFieldValue( WorkforceDTD.WORKFORCEPERSONAL_NINUMBER, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;CurrentAssignmentList&gt;</c> element.</summary>
	/// <param name="CurrentAssignment">A workforce member's assignment.</param>
	///<remarks>
	/// <para>This form of <c>setCurrentAssignmentList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>CurrentAssignmentList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void SetCurrentAssignmentList( CurrentAssignment CurrentAssignment ) {
		RemoveChild( WorkforceDTD.WORKFORCEPERSONAL_CURRENTASSIGNMENTLIST);
		AddChild( WorkforceDTD.WORKFORCEPERSONAL_CURRENTASSIGNMENTLIST, new CurrentAssignmentList( CurrentAssignment ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CurrentAssignmentList&gt;</c> element.
	/// </summary>
	/// <value> A CurrentAssignmentList </value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this null as: "A list of assignments associated with a workforce member, including school and role.  This list serves as a quick lookup for information relating to a workforce member's postings or assignments to an LA, School, or other establishment.  An agent will operate more eficiently if the data represented here is sufficient.  Otherwise, it will be necessary for the agent to also request the WorkforceAssignment object(s)."</para>
	/// <para>To remove the <c>CurrentAssignmentList</c>, set <c>CurrentAssignmentList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public CurrentAssignmentList CurrentAssignmentList
	{
		get
		{
			return (CurrentAssignmentList)GetChild( WorkforceDTD.WORKFORCEPERSONAL_CURRENTASSIGNMENTLIST);
		}
		set
		{
			RemoveChild( WorkforceDTD.WORKFORCEPERSONAL_CURRENTASSIGNMENTLIST);
			if( value != null)
			{
				AddChild( WorkforceDTD.WORKFORCEPERSONAL_CURRENTASSIGNMENTLIST, value );
			}
		}
	}

}}
