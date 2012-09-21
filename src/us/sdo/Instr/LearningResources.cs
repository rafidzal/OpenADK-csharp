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

/// <summary>A LearningResources</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.5</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class LearningResources : SifKeyedList<LearningResourceRefId>
{
	/// <summary>
	/// Creates an instance of a LearningResources
	/// </summary>
	public LearningResources() : base ( InstrDTD.LEARNINGRESOURCES ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="learningResourceRefId">Link to an aligned LearningResource object.</param>
	///
	public LearningResources( LearningResourceRefId learningResourceRefId ) : base( InstrDTD.LEARNINGRESOURCES )
	{
		this.SafeAddChild( InstrDTD.LEARNINGRESOURCES_LEARNINGRESOURCEREFID, learningResourceRefId );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected LearningResources( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;LearningResourceRefId&gt;</c> element.</summary>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;LearningResourceRefId&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setLearningResourceRefId</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddLearningResourceRefId</c></para>
	/// <para>Version: 2.5</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddLearningResourceRefId( string Value ) {
		AddChild( InstrDTD.LEARNINGRESOURCES_LEARNINGRESOURCEREFID, new LearningResourceRefId( Value ) );
	}

}}