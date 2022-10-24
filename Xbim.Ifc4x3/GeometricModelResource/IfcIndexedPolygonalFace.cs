// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4x3.MeasureResource;
using Xbim.Ifc4x3.PresentationAppearanceResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4x3.GeometricModelResource;
//## Custom using statements
//##


namespace Xbim.Ifc4x3.GeometricModelResource
{
	[ExpressType("IfcIndexedPolygonalFace", 1321)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcIndexedPolygonalFace : IfcTessellatedItem, IInstantiableEntity, IEquatable<@IfcIndexedPolygonalFace>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcIndexedPolygonalFace(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_coordIndex = new ItemSet<IfcPositiveInteger>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcPositiveInteger> _coordIndex;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, new int [] { 3 }, new int [] { -1 }, 3)]
		public IItemSet<IfcPositiveInteger> @CoordIndex 
		{ 
			get 
			{
				if(_activated) return _coordIndex;
				Activate();
				return _coordIndex;
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("Faces")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 1 }, new int [] { -1 }, 4)]
		public IEnumerable<IfcPolygonalFaceSet> @ToFaceSet 
		{ 
			get 
			{
				return Model.Instances.Where<IfcPolygonalFaceSet>(e => e.Faces != null &&  e.Faces.Contains(this), "Faces", this);
			} 
		}
		[InverseProperty("TexCoordsOf")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { 1 }, 5)]
		public IEnumerable<IfcTextureCoordinateIndices> @HasTexCoords 
		{ 
			get 
			{
				return Model.Instances.Where<IfcTextureCoordinateIndices>(e => Equals(e.TexCoordsOf), "TexCoordsOf", this);
			} 
		}
		#endregion

		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_coordIndex.InternalAdd(value.IntegerVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcIndexedPolygonalFace other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}