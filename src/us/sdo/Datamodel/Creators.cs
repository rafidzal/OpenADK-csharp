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

namespace OpenADK.Library.us.Datamodel{

/// <summary>A Creators</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class Creators : SifKeyedList<Creator>
{
	/// <summary>
	/// Creates an instance of a Creators
	/// </summary>
	public Creators() : base ( DatamodelDTD.CREATORS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="creator">A Creator</param>
	///
	public Creators( Creator creator ) : base( DatamodelDTD.CREATORS )
	{
		this.SafeAddChild( DatamodelDTD.CREATORS_CREATOR, creator );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Creators( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { DatamodelDTD.CREATORS_CREATOR }; }
	}

	///<summary>Adds the value of the <c>&lt;Creator&gt;</c> element.</summary>
	/// <param name="Name">Human-readable name of the data's creator. If the object contains system-generated data, the name should identify the creating service or application.</param>
	/// <param name="Id">Unique identifier of the creator. An email address or URI could be used here.</param>
	///<remarks>
	/// <para>This form of <c>setCreator</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddCreator</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddCreator( string Name, string Id ) {
		AddChild( DatamodelDTD.CREATORS_CREATOR, new Creator( Name, Id ) );
	}

}}
