// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.ProductExtension;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.ProductExtension
{
	[ExpressType("IfcRelPositions", 1479)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelPositions : IfcRelConnects, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelPositions>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelPositions(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_relatedProducts = new ItemSet<IfcProduct>( this, 0,  6);
		}

		#region Explicit attribute fields
		private IfcPositioningElement _relatingPositioningElement;
		private readonly ItemSet<IfcProduct> _relatedProducts;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(5, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcPositioningElement @RelatingPositioningElement 
		{ 
			get 
			{
				if(_activated) return _relatingPositioningElement;
				Activate();
				return _relatingPositioningElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _relatingPositioningElement = v, _relatingPositioningElement, value,  "RelatingPositioningElement", 5);
			} 
		}	
		[IndexedProperty]
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 6)]
		public IItemSet<IfcProduct> @RelatedProducts 
		{ 
			get 
			{
				if(_activated) return _relatedProducts;
				Activate();
				return _relatedProducts;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 4: 
					_relatingPositioningElement = (IfcPositioningElement)(value.EntityVal);
					return;
				case 5: 
					_relatedProducts.InternalAdd((IfcProduct)value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelPositions other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@RelatingPositioningElement != null)
					yield return @RelatingPositioningElement;
				foreach(var entity in @RelatedProducts)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingPositioningElement != null)
					yield return @RelatingPositioningElement;
				foreach(var entity in @RelatedProducts)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}