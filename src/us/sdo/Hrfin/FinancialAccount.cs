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

namespace OpenADK.Library.us.Hrfin{

/// <summary>This object communicates information about a financial account.  SIF_Events are reported.</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 1.5r1</para>
/// </remarks>
[Serializable]
public class FinancialAccount : SifDataObject
{
	/// <summary>
	/// Creates an instance of a FinancialAccount
	/// </summary>
	public FinancialAccount() : base( Adk.SifVersion, HrfinDTD.FINANCIALACCOUNT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="refId">GUID that identifies this financial account.</param>
	///<param name="accountNumber">Account number used for ledger.</param>
	///<param name="name">Name of the account.</param>
	///<param name="financialClassRefId">Financial class of the account.</param>
	///<param name="creationDate">Account creation date.</param>
	///<param name="creationTime">Account creation time.</param>
	///
	public FinancialAccount( string refId, string accountNumber, string name, string financialClassRefId, DateTime? creationDate, DateTime? creationTime ) : base( Adk.SifVersion, HrfinDTD.FINANCIALACCOUNT )
	{
		this.RefId = refId;
		this.AccountNumber = accountNumber;
		this.Name = name;
		this.FinancialClassRefId = financialClassRefId;
		this.CreationDate = creationDate;
		this.CreationTime = creationTime;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected FinancialAccount( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { HrfinDTD.FINANCIALACCOUNT_REFID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>RefId</c> attribute.
	/// </summary>
	/// <value> The <c>RefId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this attribute as: "GUID that identifies this financial account."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public override string RefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.FINANCIALACCOUNT_REFID ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALACCOUNT_REFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;AccountNumber&gt;</c> element.
	/// </summary>
	/// <value> The <c>AccountNumber</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Account number used for ledger."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string AccountNumber
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.FINANCIALACCOUNT_ACCOUNTNUMBER ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALACCOUNT_ACCOUNTNUMBER, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Name&gt;</c> element.
	/// </summary>
	/// <value> The <c>Name</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Name of the account."</para>
	/// <para>This element is known by more than one tag name depending on the version of SIF in use. 
	/// The ADK will use the tag names shown below when parsing and rendering elements of this kind.</para>
	/// <list type="table"><listheader><term>Version</term><description>Tag</description></listheader>;
	/// <item><term>2.0 (and greater)</term><description>&lt;Name&gt;</description></item>
	/// </list>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Name
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.FINANCIALACCOUNT_NAME ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALACCOUNT_NAME, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;Description&gt;</c> element.
	/// </summary>
	/// <value> The <c>Description</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Description."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string Description
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.FINANCIALACCOUNT_DESCRIPTION ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALACCOUNT_DESCRIPTION, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;FinancialClassRefId&gt;</c> element.
	/// </summary>
	/// <value> The <c>FinancialClassRefId</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Financial class of the account."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public string FinancialClassRefId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( HrfinDTD.FINANCIALACCOUNT_FINANCIALCLASSREFID ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALACCOUNT_FINANCIALCLASSREFID, new SifString( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CreationDate&gt;</c> element.
	/// </summary>
	/// <value> The <c>CreationDate</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Account creation date."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? CreationDate
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( HrfinDTD.FINANCIALACCOUNT_CREATIONDATE ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALACCOUNT_CREATIONDATE, new SifDate( value ), value );
		}
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;CreationTime&gt;</c> element.
	/// </summary>
	/// <value> The <c>CreationTime</c> element of this object.</value>
	/// <remarks>
	/// <para>The SIF specification defines the meaning of this element as: "Account creation time."</para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 1.5r1</para>
	/// </remarks>
	public DateTime? CreationTime
	{
		get
		{
			return (DateTime?) GetSifSimpleFieldValue( HrfinDTD.FINANCIALACCOUNT_CREATIONTIME ) ;
		}
		set
		{
			SetFieldValue( HrfinDTD.FINANCIALACCOUNT_CREATIONTIME, new SifTime( value ), value );
		}
	}

}}
