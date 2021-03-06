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

namespace OpenADK.Library.au.Learning{

/// <summary>A TeacherList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class TeacherList : SifList<TeachingGroupTeacher>
{
	/// <summary>
	/// Creates an instance of a TeacherList
	/// </summary>
	public TeacherList() : base ( LearningDTD.TEACHERLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="teachingGroupTeacher">A TeachingGroupTeacher</param>
	///
	public TeacherList( TeachingGroupTeacher teachingGroupTeacher ) : base( LearningDTD.TEACHERLIST )
	{
		this.SafeAddChild( LearningDTD.TEACHERLIST_TEACHINGGROUPTEACHER, teachingGroupTeacher );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected TeacherList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { LearningDTD.TEACHERLIST_TEACHINGGROUPTEACHER }; }
	}

	///<summary>Adds the value of the <c>&lt;TeachingGroupTeacher&gt;</c> element.</summary>
	/// <param name="StaffLocalId">A StaffLocalId</param>
	/// <param name="Name">A Name</param>
	/// <param name="Association">An Association</param>
	///<remarks>
	/// <para>This form of <c>setTeachingGroupTeacher</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddTeachingGroupTeacher</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void AddTeachingGroupTeacher( string StaffLocalId, Name Name, string Association ) {
		AddChild( LearningDTD.TEACHERLIST_TEACHINGGROUPTEACHER, new TeachingGroupTeacher( StaffLocalId, Name, Association ) );
	}

}}
