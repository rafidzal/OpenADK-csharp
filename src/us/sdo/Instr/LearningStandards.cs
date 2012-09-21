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

/// <summary>A LearningStandards</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class LearningStandards : SifKeyedList<LearningStandardItemRefId>
{
	/// <summary>
	/// Creates an instance of a LearningStandards
	/// </summary>
	public LearningStandards() : base ( InstrDTD.LEARNINGSTANDARDS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="learningStandardItemRefId">GUID of an associated LearningStandardItem object</param>
	///
	public LearningStandards( LearningStandardItemRefId learningStandardItemRefId ) : base( InstrDTD.LEARNINGSTANDARDS )
	{
		this.SafeAddChild( InstrDTD.LEARNINGSTANDARDS_LEARNINGSTANDARDITEMREFID, learningStandardItemRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected LearningStandards( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;LearningStandardItemRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;LearningStandardItemRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setLearningStandardItemRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddLearningStandardItemRefId</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddLearningStandardItemRefId( string Value ) {
		AddChild( InstrDTD.LEARNINGSTANDARDS_LEARNINGSTANDARDITEMREFID, new LearningStandardItemRefId( Value ) );
	}

}}