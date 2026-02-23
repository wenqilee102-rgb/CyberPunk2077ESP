using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entPhysicalFractureFieldComponent : entPhysicalTriggerComponent
	{
		private physicsFractureFieldParams _fractureFieldParams;

		[Ordinal(9)] 
		[RED("fractureFieldParams")] 
		public physicsFractureFieldParams FractureFieldParams
		{
			get => GetProperty(ref _fractureFieldParams);
			set => SetProperty(ref _fractureFieldParams, value);
		}

		public entPhysicalFractureFieldComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
