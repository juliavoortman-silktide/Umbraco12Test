//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Contact</summary>
	[PublishedModel("contact")]
	public partial class Contact : PublishedContentModel, INavigationBase
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		public new const string ModelTypeAlias = "contact";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<Contact, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public Contact(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Contact Form Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactFormHeader")]
		public virtual string ContactFormHeader => this.Value<string>(_publishedValueFallback, "contactFormHeader");

		///<summary>
		/// Contact Intro
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("contactIntro")]
		public virtual global::Umbraco.Cms.Core.Strings.IHtmlEncodedString ContactIntro => this.Value<global::Umbraco.Cms.Core.Strings.IHtmlEncodedString>(_publishedValueFallback, "contactIntro");

		///<summary>
		/// Map Coordinates
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mapCoordinates")]
		public virtual global::Bergmania.OpenStreetMap.OpenStreetMapModel MapCoordinates => this.Value<global::Bergmania.OpenStreetMap.OpenStreetMapModel>(_publishedValueFallback, "mapCoordinates");

		///<summary>
		/// Map Header
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("mapHeader")]
		public virtual string MapHeader => this.Value<string>(_publishedValueFallback, "mapHeader");

		///<summary>
		/// Page Title: The title of the page, this is also the first text in a google search result. The ideal length is between 40 and 60 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is considered optional since most modern search engines don't use this anymore
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("keywords")]
		public virtual global::System.Collections.Generic.IEnumerable<string> Keywords => global::Umbraco.Cms.Web.Common.PublishedModels.NavigationBase.GetKeywords(this, _publishedValueFallback);

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("seoMetaDescription")]
		public virtual string SeoMetaDescription => global::Umbraco.Cms.Web.Common.PublishedModels.NavigationBase.GetSeoMetaDescription(this, _publishedValueFallback);

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc004+dd72c18b19a7d13bb5d50e09ec09c637438a5766")]
		[ImplementPropertyType("umbracoNavihide")]
		public virtual bool UmbracoNavihide => global::Umbraco.Cms.Web.Common.PublishedModels.NavigationBase.GetUmbracoNavihide(this, _publishedValueFallback);
	}
}
