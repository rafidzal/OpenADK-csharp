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

namespace OpenADK.Library.au.Common{

/// <summary>A Language</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.3</para>
/// </remarks>
[Serializable]
public class Language : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a Language
	/// </summary>
	public Language() : base ( CommonDTD.LANGUAGE ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="code">
	/// The code representing the specific language that an
	/// individual uses to communicate.</param>
	///<param name="value">Gets or sets the content value of the &amp;lt;Language&amp;gt; element</param>
	///
	public Language( AustralianClassificationOfLanguagesType code, string value ) : base( CommonDTD.LANGUAGE )
	{
		this.SetCode( code );
		this.Value = value;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected Language( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { CommonDTD.LANGUAGE_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Language&gt;</c> element.
	/// </summary>
	/// <value> The <c>Value</c> of the content of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this of the content as: "Gets or sets the content value of the &amp;lt;Language&amp;gt; element"</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Value
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.LANGUAGE ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.LANGUAGE, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "
	/// The code representing the specific language that an
	/// individual uses to communicate."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Code
	{
		get
		{ 
			return GetFieldValue( CommonDTD.LANGUAGE_CODE );
		}
		set
		{
			SetField( CommonDTD.LANGUAGE_CODE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;Code&gt;</c> element.
	/// </summary>
	/// <param name="val">A AustralianClassificationOfLanguagesType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "
	/// The code representing the specific language that an
	/// individual uses to communicate."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetCode( AustralianClassificationOfLanguagesType val )
	{
		SetField( CommonDTD.LANGUAGE_CODE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;OtherCodeList&gt;</c> element.
	/// </summary>
	/// <value> An OtherCodeList </value>
	/// <remarks>
	/// <para>To remove the <c>OtherCodeList</c>, set <c>OtherCodeList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public OtherCodeList OtherCodeList
	{
		get
		{
			return (OtherCodeList)GetChild( CommonDTD.LANGUAGE_OTHERCODELIST);
		}
		set
		{
			RemoveChild( CommonDTD.LANGUAGE_OTHERCODELIST);
			if( value != null)
			{
				AddChild( CommonDTD.LANGUAGE_OTHERCODELIST, value );
			}
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;LanguageType&gt;</c> element.
	/// </summary>
	/// <value> The <c>LanguageType</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "
	/// An indication of the function and context in which an
	/// individual uses a language to communicate."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string LanguageType
	{
		get
		{ 
			return GetFieldValue( CommonDTD.LANGUAGE_LANGUAGETYPE );
		}
		set
		{
			SetField( CommonDTD.LANGUAGE_LANGUAGETYPE, value );
		}
	}

	/// <summary>
	/// Sets the value of the <c>&lt;LanguageType&gt;</c> element.
	/// </summary>
	/// <param name="val">A AULanguageType object</param>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "
	/// An indication of the function and context in which an
	/// individual uses a language to communicate."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public void SetLanguageType( AULanguageType val )
	{
		SetField( CommonDTD.LANGUAGE_LANGUAGETYPE, val );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Dialect&gt;</c> element.
	/// </summary>
	/// <value> The <c>Dialect</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Specific dialect of a person's language."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.3</para>
	/// </remarks>
	public string Dialect
	{
		get
		{
			return (string) GetSifSimpleFieldValue( CommonDTD.LANGUAGE_DIALECT ) ;
		}
		set
		{
			SetFieldValue( CommonDTD.LANGUAGE_DIALECT, new SifString( value ), value );
		}
	}

}}
