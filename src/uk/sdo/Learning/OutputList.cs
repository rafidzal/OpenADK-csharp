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

namespace OpenADK.Library.uk.Learning{

/// <summary>An OutputList</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class OutputList : SifKeyedList<Output>
{
	/// <summary>
	/// Creates an instance of an OutputList
	/// </summary>
	public OutputList() : base ( LearningDTD.OUTPUTLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="output">An Output</param>
	///
	public OutputList( Output output ) : base( LearningDTD.OUTPUTLIST )
	{
		this.SafeAddChild( LearningDTD.OUTPUTLIST_OUTPUT, output );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected OutputList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { LearningDTD.OUTPUTLIST_OUTPUT }; }
	}

	///<summary>Adds the value of the <c>&lt;Output&gt;</c> element.</summary>
	/// <param name="Type">"TG" has special meaning – it means this is the bottom of the "tree" and the output is a TeachingGroup. "YR" means a year (or "principal division") within the school (7,8,9,etc).</param>
	///<remarks>
	/// <para>This form of <c>setOutput</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddOutput</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void AddOutput( OutputType Type ) {
		AddChild( LearningDTD.OUTPUTLIST_OUTPUT, new Output( Type ) );
	}

}}
