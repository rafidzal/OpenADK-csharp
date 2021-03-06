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

namespace OpenADK.Library.Global{

/// <summary>The following element is supported at the end of all SIF objects.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class SIF_ExtendedElements : SifActionList<SIF_ExtendedElement>
{
	/// <summary>
	/// Creates an instance of a SIF_ExtendedElements
	/// </summary>
	public SIF_ExtendedElements() : base ( GlobalDTD.SIF_EXTENDEDELEMENTS ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifExtendedElement">A name/value pair, the name being contained in the Name attribute, the value being the element content.</param>
	///
	public SIF_ExtendedElements( SIF_ExtendedElement sifExtendedElement ) : base( GlobalDTD.SIF_EXTENDEDELEMENTS )
	{
		this.SafeAddChild( GlobalDTD.SIF_EXTENDEDELEMENTS_SIF_EXTENDEDELEMENT, sifExtendedElement );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_ExtendedElements( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	///<summary>Adds the value of the <c>&lt;SIF_ExtendedElement&gt;</c> element.</summary>
	/// <param name="Name">The name of the extended element. As it is possible that names for extended elements may collide from agent to agent, it is recommended that the names of extended elements be configurable in an agent, or that agents use URIs for the names of extended elements.</param>
	/// <param name="Value">Gets or sets the content value of the &amp;lt;SIF_ExtendedElement&amp;gt; element</param>
	///<remarks>
	/// <para>This form of <c>setSIF_ExtendedElement</c> is provided as a convenience method
	/// that is functionally equivalent to the method <c>AddSIF_ExtendedElement</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public void AddSIF_ExtendedElement( string Name, string Value ) {
		AddChild( GlobalDTD.SIF_EXTENDEDELEMENTS_SIF_EXTENDEDELEMENT, new SIF_ExtendedElement( Name, Value ) );
	}

}}
