using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ControlledDeviceData : WidgetCustomData
	{
		private CBool _isActive;
		private CBool _isNest;

		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(1)] 
		[RED("isNest")] 
		public CBool IsNest
		{
			get => GetProperty(ref _isNest);
			set => SetProperty(ref _isNest, value);
		}

		public ControlledDeviceData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
