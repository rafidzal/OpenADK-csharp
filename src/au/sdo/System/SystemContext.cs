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

namespace OpenADK.Library.au.System{

/// <summary>A SystemContext</summary>
/// <remarks>
///
/// <para>Author: Generated by adkgen</para>
/// <para>Version: 2.6</para>
/// <para>Since: 2.4</para>
/// </remarks>
[Serializable]
public class SystemContext : SifKeyedElement
{
	/// <summary>
	/// Creates an instance of a SystemContext
	/// </summary>
	public SystemContext() : base ( SystemDTD.SYSTEMCONTEXT ){}

	/// <summary>
	/// Constructor that accepts values for all mandatory fields
	/// </summary>
	///<param name="systemId">A SystemId</param>
	///
	public SystemContext( string systemId ) : base( SystemDTD.SYSTEMCONTEXT )
	{
		this.SystemId = systemId;
	}

	/// <summary>
	/// Constructor used by the .Net Serialization formatter
	/// </summary>
	[SecurityPermission( SecurityAction.Demand, SerializationFormatter=true )] 
	protected SystemContext( SerializationInfo info, StreamingContext context ) : base( info, context ) {} 
	/// <summary>
	/// Gets the metadata fields that make up the key of this object
	/// </summary>
	/// <value>
	/// an array of metadata fields that make up the object's key
	/// </value>
	public override IElementDef[] KeyFields {
		get { return new IElementDef[] { SystemDTD.SYSTEMCONTEXT_SYSTEMID }; }
	}

	/// <summary>
	/// Gets or sets the value of the <c>SystemId</c> attribute.
	/// </summary>
	/// <value> The <c>SystemId</c> attribute of this object.</value>
	/// <remarks>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public string SystemId
	{
		get
		{
			return (string) GetSifSimpleFieldValue( SystemDTD.SYSTEMCONTEXT_SYSTEMID ) ;
		}
		set
		{
			SetFieldValue( SystemDTD.SYSTEMCONTEXT_SYSTEMID, new SifString( value ), value );
		}
	}

	///<summary>Sets the value of the <c>&lt;RoleList&gt;</c> element.</summary>
	/// <param name="Role">A Role</param>
	///<remarks>
	/// <para>This form of <c>setRoleList</c> is provided as a convenience method
	/// that is functionally equivalent to the <c>RoleList</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public void SetRoleList( Role Role ) {
		RemoveChild( SystemDTD.SYSTEMCONTEXT_ROLELIST);
		AddChild( SystemDTD.SYSTEMCONTEXT_ROLELIST, new RoleList( Role ) );
	}

	/// <summary>
	/// Gets or sets the value of the <c>&lt;RoleList&gt;</c> element.
	/// </summary>
	/// <value> A RoleList </value>
	/// <remarks>
	/// <para>To remove the <c>RoleList</c>, set <c>RoleList</c> to <c>null</c></para>
	/// <para>Version: 2.6</para>
	/// <para>Since: 2.4</para>
	/// </remarks>
	public RoleList RoleList
	{
		get
		{
			return (RoleList)GetChild( SystemDTD.SYSTEMCONTEXT_ROLELIST);
		}
		set
		{
			RemoveChild( SystemDTD.SYSTEMCONTEXT_ROLELIST);
			if( value != null)
			{
				AddChild( SystemDTD.SYSTEMCONTEXT_ROLELIST, value );
			}
		}
	}

}}
