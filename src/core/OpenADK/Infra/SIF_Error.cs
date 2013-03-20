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

/// <summary>A SIF_Error</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.1</para>
/// </remarks>
[Serializable]
public class SIF_Error : SifElement
{
	/// <summary>
	/// Creates an instance of a SIF_Error
	/// </summary>
	public SIF_Error() : base ( InfraDTD.SIF_ERROR ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="sifCategory">A SIF_Category</param>
	///<param name="sifCode">See Error Codes.</param>
	///<param name="sifDesc">A simple, easy to understand, description of the error. The primary consumer of this message is the application user. Example: "Unable to open database."</param>
	///
	public SIF_Error( int? sifCategory, int? sifCode, string sifDesc ) : base( InfraDTD.SIF_ERROR )
	{
		this.SIF_Category = sifCategory;
		this.SIF_Code = sifCode;
		this.SIF_Desc = sifDesc;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SIF_Error( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public  IElementDef[] KeyFields {
		get { return new IElementDef[] { InfraDTD.SIF_ERROR_SIF_CATEGORY, InfraDTD.SIF_ERROR_SIF_CODE }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Category&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Category</c> element of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public int? SIF_Category
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( InfraDTD.SIF_ERROR_SIF_CATEGORY ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_ERROR_SIF_CATEGORY, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Code&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Code</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "See Error Codes."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public int? SIF_Code
	{
		get
		{
			return (int?) GetSifSimpleFieldValue( InfraDTD.SIF_ERROR_SIF_CODE ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_ERROR_SIF_CODE, new SifInt( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_Desc&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_Desc</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "A simple, easy to understand, description of the error. The primary consumer of this message is the application user. Example: "Unable to open database.""</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SIF_Desc
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_ERROR_SIF_DESC ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_ERROR_SIF_DESC, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;SIF_ExtendedDesc&gt;</c> element.
	/// </summary>
	/// <value> The <c>SIF_ExtendedDesc</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "An optional error description that is more complete and technical in nature. It is to be used as a diagnostic message in trouble-shooting procedures. Example: "The 'Students' table is opened in exclusive mode by user 'ADM1' (dbm.cpp, line 300).""</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.1</para>
	/// </remarks>
	public string SIF_ExtendedDesc
	{
		get
		{
			return (string) GetSifSimpleFieldValue( InfraDTD.SIF_ERROR_SIF_EXTENDEDDESC ) ;
		}
		set
		{
			SetFieldValue( InfraDTD.SIF_ERROR_SIF_EXTENDEDDESC, new SifString( value ), value );
		}
	}

		#region EXTRA METHODS

// BEGIN EXTRA METHODS (C:/GitHub/rafidzal/OpenADK-java/adk-generator/../adk-generator/datadef/core/sif20/SIF_Error.txt.cs)

    public SIF_Error(SifErrorCategoryCode category, int sifCode, string sifDesc, string sifExtDesc)
            : this((int)category, sifCode, sifDesc)
        {
            this.SIF_ExtendedDesc = sifExtDesc;
        }


        public override string ToString()
        {
            System.Text.StringBuilder buf = new System.Text.StringBuilder();

            try
            {
                buf.Append("[Category=");
                buf.Append(SIF_Category);
                buf.Append("; Code=");
                buf.Append(SIF_Code);
                buf.Append("] ");

                string desc = SIF_Desc;
                if (desc != null)
                    buf.Append(desc);
                desc = SIF_ExtendedDesc;
                if (desc != null)
                {
                    buf.Append(": ");
                    buf.Append(desc);
                }
            }
            catch (System.Exception thr)
            {
                System.Console.Out.WriteLine(thr);
                System.Console.Out.WriteLine(thr.StackTrace);
            }

            return buf.ToString();
        }

// END EXTRA METHODS

		#endregion // EXTRA METHODS
}}
