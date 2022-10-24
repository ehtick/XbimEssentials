// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

//## Custom using statements
//##

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc4x3.ProductExtension
{
	public partial class @IfcTransportElement : IIfcTransportElement
	{

		[CrossSchemaAttribute(typeof(IIfcTransportElement), 9)]
		Ifc4.Interfaces.IfcTransportElementTypeEnum? IIfcTransportElement.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcTransportElementTypeEnum.CRANEWAY:
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.CRANEWAY;
					case IfcTransportElementTypeEnum.ELEVATOR:
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.ELEVATOR;
					case IfcTransportElementTypeEnum.ESCALATOR:
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.ESCALATOR;
					case IfcTransportElementTypeEnum.HAULINGGEAR:
						//## Handle translation of HAULINGGEAR member from IfcTransportElementTypeEnum in property PredefinedType
						//TODO: Handle translation of HAULINGGEAR member from IfcTransportElementTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcTransportElementTypeEnum.LIFTINGGEAR:
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.LIFTINGGEAR;
					case IfcTransportElementTypeEnum.MOVINGWALKWAY:
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.MOVINGWALKWAY;
					case IfcTransportElementTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.USERDEFINED;
					case IfcTransportElementTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcTransportElementTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcTransportElementTypeEnum.ELEVATOR:
						PredefinedType = IfcTransportElementTypeEnum.ELEVATOR;
						return;
					case Ifc4.Interfaces.IfcTransportElementTypeEnum.ESCALATOR:
						PredefinedType = IfcTransportElementTypeEnum.ESCALATOR;
						return;
					case Ifc4.Interfaces.IfcTransportElementTypeEnum.MOVINGWALKWAY:
						PredefinedType = IfcTransportElementTypeEnum.MOVINGWALKWAY;
						return;
					case Ifc4.Interfaces.IfcTransportElementTypeEnum.CRANEWAY:
						PredefinedType = IfcTransportElementTypeEnum.CRANEWAY;
						return;
					case Ifc4.Interfaces.IfcTransportElementTypeEnum.LIFTINGGEAR:
						PredefinedType = IfcTransportElementTypeEnum.LIFTINGGEAR;
						return;
					case Ifc4.Interfaces.IfcTransportElementTypeEnum.USERDEFINED:
						PredefinedType = IfcTransportElementTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcTransportElementTypeEnum.NOTDEFINED:
						PredefinedType = IfcTransportElementTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}