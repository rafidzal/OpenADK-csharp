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

/// <summary>An AssociatedObjects</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class AssociatedObjects : SifKeyedList<AssociatedObject>
{
	/// <summary>
	/// Creates an instance of an AssociatedObjects
	/// </summary>
	public AssociatedObjects() : base ( LearningDTD.ASSOCIATEDOBJECTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="associatedObject">An AssociatedObject</param>
	///
	public AssociatedObjects( AssociatedObject associatedObject ) : base( LearningDTD.ASSOCIATEDOBJECTS )
	{
		this.SafeAddChild( LearningDTD.ASSOCIATEDOBJECTS_ASSOCIATEDOBJECT, associatedObject );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected AssociatedObjects( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;AssociatedObject&gt;</c> element.</summary>
	/// <param name="SifRefObject">A SIF_RefObject</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;AssociatedObject&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setAssociatedObject</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddAssociatedObject</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void AddAssociatedObject( string SifRefObject, string Value ) {
		AddChild( LearningDTD.ASSOCIATEDOBJECTS_ASSOCIATEDOBJECT, new AssociatedObject( SifRefObject, Value ) );
	}

}}
