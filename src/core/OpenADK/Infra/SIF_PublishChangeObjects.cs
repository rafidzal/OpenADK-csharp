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

namespace OpenADK.Library.Infra{

/// <summary>A SIF_PublishChangeObjects</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class SIF_PublishChangeObjects : SifKeyedList<SIF_Object>
{
	/// <summary>
	/// Creates an instance of a SIF_PublishChangeObjects
	/// </summary>
	public SIF_PublishChangeObjects() : base ( InfraDTD.SIF_PUBLISHCHANGEOBJECTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifObject">A SIF_Object</param>
	///
	public SIF_PublishChangeObjects( SIF_Object sifObject ) : base( InfraDTD.SIF_PUBLISHCHANGEOBJECTS )
	{
		this.SafeAddChild( InfraDTD.SIF_PUBLISHCHANGEOBJECTS_SIF_OBJECT, sifObject );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_PublishChangeObjects( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_PUBLISHCHANGEOBJECTS_SIF_OBJECT }; }
	}

	///<summary>Adds the value of the <c>&lt;SIF_Object&gt;</c> element.</summary>
	/// <param name="ObjectName">The name of a SIF data object</param>
	///<remarks>
	/// <para>This form of <c>setSIF_Object</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSIF_Object</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.0</para>
	/// </remarks>
	public void AddSIF_Object( string ObjectName ) {
		AddChild( InfraDTD.SIF_PUBLISHCHANGEOBJECTS_SIF_OBJECT, new SIF_Object( ObjectName ) );
	}

}}
