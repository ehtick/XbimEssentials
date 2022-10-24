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
namespace Xbim.Ifc4x3.BuildingControlsDomain
{
	public partial class @IfcFlowInstrumentType : IIfcFlowInstrumentType
	{

		[CrossSchemaAttribute(typeof(IIfcFlowInstrumentType), 10)]
		Ifc4.Interfaces.IfcFlowInstrumentTypeEnum IIfcFlowInstrumentType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcFlowInstrumentTypeEnum.AMMETER:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.AMMETER;
					case IfcFlowInstrumentTypeEnum.COMBINED:
						//## Handle translation of COMBINED member from IfcFlowInstrumentTypeEnum in property PredefinedType
						//TODO: Handle translation of COMBINED member from IfcFlowInstrumentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcFlowInstrumentTypeEnum.FREQUENCYMETER:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.FREQUENCYMETER;
					case IfcFlowInstrumentTypeEnum.PHASEANGLEMETER:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.PHASEANGLEMETER;
					case IfcFlowInstrumentTypeEnum.POWERFACTORMETER:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.POWERFACTORMETER;
					case IfcFlowInstrumentTypeEnum.PRESSUREGAUGE:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.PRESSUREGAUGE;
					case IfcFlowInstrumentTypeEnum.THERMOMETER:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.THERMOMETER;
					case IfcFlowInstrumentTypeEnum.VOLTMETER:
						//## Handle translation of VOLTMETER member from IfcFlowInstrumentTypeEnum in property PredefinedType
						//TODO: Handle translation of VOLTMETER member from IfcFlowInstrumentTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcFlowInstrumentTypeEnum.VOLTMETER_PEAK:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.VOLTMETER_PEAK;
					case IfcFlowInstrumentTypeEnum.VOLTMETER_RMS:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.VOLTMETER_RMS;
					case IfcFlowInstrumentTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.USERDEFINED;
					case IfcFlowInstrumentTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.PRESSUREGAUGE:
						PredefinedType = IfcFlowInstrumentTypeEnum.PRESSUREGAUGE;
						return;
					case Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.THERMOMETER:
						PredefinedType = IfcFlowInstrumentTypeEnum.THERMOMETER;
						return;
					case Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.AMMETER:
						PredefinedType = IfcFlowInstrumentTypeEnum.AMMETER;
						return;
					case Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.FREQUENCYMETER:
						PredefinedType = IfcFlowInstrumentTypeEnum.FREQUENCYMETER;
						return;
					case Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.POWERFACTORMETER:
						PredefinedType = IfcFlowInstrumentTypeEnum.POWERFACTORMETER;
						return;
					case Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.PHASEANGLEMETER:
						PredefinedType = IfcFlowInstrumentTypeEnum.PHASEANGLEMETER;
						return;
					case Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.VOLTMETER_PEAK:
						PredefinedType = IfcFlowInstrumentTypeEnum.VOLTMETER_PEAK;
						return;
					case Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.VOLTMETER_RMS:
						PredefinedType = IfcFlowInstrumentTypeEnum.VOLTMETER_RMS;
						return;
					case Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.USERDEFINED:
						PredefinedType = IfcFlowInstrumentTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcFlowInstrumentTypeEnum.NOTDEFINED:
						PredefinedType = IfcFlowInstrumentTypeEnum.NOTDEFINED;
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