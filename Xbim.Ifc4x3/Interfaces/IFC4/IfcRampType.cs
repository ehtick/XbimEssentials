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
namespace Xbim.Ifc4x3.SharedBldgElements
{
	public partial class @IfcRampType : IIfcRampType
	{

		[CrossSchemaAttribute(typeof(IIfcRampType), 10)]
		Ifc4.Interfaces.IfcRampTypeEnum IIfcRampType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcRampTypeEnum.HALF_TURN_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.HALF_TURN_RAMP;
					case IfcRampTypeEnum.QUARTER_TURN_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.QUARTER_TURN_RAMP;
					case IfcRampTypeEnum.SPIRAL_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.SPIRAL_RAMP;
					case IfcRampTypeEnum.STRAIGHT_RUN_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.STRAIGHT_RUN_RAMP;
					case IfcRampTypeEnum.TWO_QUARTER_TURN_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.TWO_QUARTER_TURN_RAMP;
					case IfcRampTypeEnum.TWO_STRAIGHT_RUN_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.TWO_STRAIGHT_RUN_RAMP;
					case IfcRampTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcRampTypeEnum.USERDEFINED;
					case IfcRampTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcRampTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcRampTypeEnum.STRAIGHT_RUN_RAMP:
						PredefinedType = IfcRampTypeEnum.STRAIGHT_RUN_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.TWO_STRAIGHT_RUN_RAMP:
						PredefinedType = IfcRampTypeEnum.TWO_STRAIGHT_RUN_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.QUARTER_TURN_RAMP:
						PredefinedType = IfcRampTypeEnum.QUARTER_TURN_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.TWO_QUARTER_TURN_RAMP:
						PredefinedType = IfcRampTypeEnum.TWO_QUARTER_TURN_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.HALF_TURN_RAMP:
						PredefinedType = IfcRampTypeEnum.HALF_TURN_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.SPIRAL_RAMP:
						PredefinedType = IfcRampTypeEnum.SPIRAL_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.USERDEFINED:
						PredefinedType = IfcRampTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.NOTDEFINED:
						PredefinedType = IfcRampTypeEnum.NOTDEFINED;
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