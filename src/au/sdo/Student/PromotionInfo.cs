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

namespace OpenADK.Library.au.Student{

/// <summary>A PromotionInfo</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class PromotionInfo : SifElement
{
	/// <summary>
	/// Creates an instance of a PromotionInfo
	/// </summary>
	public PromotionInfo() : base ( StudentDTD.PROMOTIONINFO ){}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected PromotionInfo( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets or sets the value of the <c>&lt;PromotionStatus&gt;</c> element.
	/// </summary>
	/// <value> The <c>PromotionStatus</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This value should be set if this enrollment instance is closed for an end-of-year closeout or a mid-year promotion or demotion. A value other than NA should be specified when the enrollment instance represents an end-of-year closeout or mid-year promotion/demotion."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string PromotionStatus
	{
		get
		{ 
			return GetFieldValue( StudentDTD.PROMOTIONINFO_PROMOTIONSTATUS );
		}
		set
		{
			SetField( StudentDTD.PROMOTIONINFO_PROMOTIONSTATUS, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;PromotionStatus&gt;</c> element.
	/// </summary>
	/// <param name="val">A PromotionStatus object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "This value should be set if this enrollment instance is closed for an end-of-year closeout or a mid-year promotion or demotion. A value other than NA should be specified when the enrollment instance represents an end-of-year closeout or mid-year promotion/demotion."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetPromotionStatus( PromotionStatus val )
	{
		SetField( StudentDTD.PROMOTIONINFO_PROMOTIONSTATUS, val );
	}

}}
