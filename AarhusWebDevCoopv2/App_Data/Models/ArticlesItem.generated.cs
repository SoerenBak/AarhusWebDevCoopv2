//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Articles Item</summary>
	[PublishedContentModel("articlesItem")]
	public partial class ArticlesItem : Master
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "articlesItem";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ArticlesItem(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ArticlesItem, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Article Content
		///</summary>
		[ImplementPropertyType("articleContent")]
		public IHtmlString ArticleContent
		{
			get { return this.GetPropertyValue<IHtmlString>("articleContent"); }
		}

		///<summary>
		/// Articles Title
		///</summary>
		[ImplementPropertyType("articlesTitle")]
		public string ArticlesTitle
		{
			get { return this.GetPropertyValue<string>("articlesTitle"); }
		}
	}
}
