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

namespace OpenADK.Library.us.Common{

/// <summary>A SubjectAreas</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class SubjectAreas : SifKeyedList<SubjectArea>
{
	/// <summary>
	/// Creates an instance of a SubjectAreas
	/// </summary>
	public SubjectAreas() : base ( CommonDTD.SUBJECTAREAS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="subjectArea">A SubjectArea</param>
	///
	public SubjectAreas( SubjectArea subjectArea ) : base( CommonDTD.SUBJECTAREAS )
	{
		this.SafeAddChild( CommonDTD.SUBJECTAREAS_SUBJECTAREA, subjectArea );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SubjectAreas( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;SubjectArea&gt;</c> element.</summary>
	/// <param name="Code">The subject area code (i.e. the first two digits of the course classification code)</param>
	///<remarks>
	/// <para>This form of <c>setSubjectArea</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSubjectArea</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddSubjectArea( string Code ) {
		AddChild( CommonDTD.SUBJECTAREAS_SUBJECTAREA, new SubjectArea( Code ) );
	}

}}