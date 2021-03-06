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

namespace OpenADK.Library.uk.Learner{

/// <summary>A list of known previous schools or establishments.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.0</para>
/// </remarks>
[Serializable]
public class PreviousEstablishmentList : SifList<PreviousEstablishment>
{
	/// <summary>
	/// Creates an instance of a PreviousEstablishmentList
	/// </summary>
	public PreviousEstablishmentList() : base ( LearnerDTD.PREVIOUSESTABLISHMENTLIST ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="previousEstablishment">A previous school or establishment.</param>
	///
	public PreviousEstablishmentList( PreviousEstablishment previousEstablishment ) : base( LearnerDTD.PREVIOUSESTABLISHMENTLIST )
	{
		this.SafeAddChild( LearnerDTD.PREVIOUSESTABLISHMENTLIST_PREVIOUSESTABLISHMENT, previousEstablishment );
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PreviousEstablishmentList( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
}}
