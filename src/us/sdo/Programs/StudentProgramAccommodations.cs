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

namespace OpenADK.Library.us.Programs{

/// <summary>A StudentProgramAccommodations</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class StudentProgramAccommodations : SifList<StudentProgramAccommodation>
{
	/// <summary>
	/// Creates an instance of a StudentProgramAccommodations
	/// </summary>
	public StudentProgramAccommodations() : base ( ProgramsDTD.STUDENTPROGRAMACCOMMODATIONS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="studentProgramAccommodation">A StudentProgramAccommodation</param>
	///
	public StudentProgramAccommodations( StudentProgramAccommodation studentProgramAccommodation ) : base( ProgramsDTD.STUDENTPROGRAMACCOMMODATIONS )
	{
		this.SafeAddChild( ProgramsDTD.STUDENTPROGRAMACCOMMODATIONS_STUDENTPROGRAMACCOMMODATION, studentProgramAccommodation );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected StudentProgramAccommodations( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
}}