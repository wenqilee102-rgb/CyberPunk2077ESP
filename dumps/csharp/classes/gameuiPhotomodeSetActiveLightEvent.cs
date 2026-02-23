using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotomodeSetActiveLightEvent : redEvent
	{
		private CBool _isLightTabActive;
		private CBool _isCurrentLightEnabled;
		private CInt32 _lightIndex;

		[Ordinal(0)] 
		[RED("isLightTabActive")] 
		public CBool IsLightTabActive
		{
			get => GetProperty(ref _isLightTabActive);
			set => SetProperty(ref _isLightTabActive, value);
		}

		[Ordinal(1)] 
		[RED("isCurrentLightEnabled")] 
		public CBool IsCurrentLightEnabled
		{
			get => GetProperty(ref _isCurrentLightEnabled);
			set => SetProperty(ref _isCurrentLightEnabled, value);
		}

		[Ordinal(2)] 
		[RED("lightIndex")] 
		public CInt32 LightIndex
		{
			get => GetProperty(ref _lightIndex);
			set => SetProperty(ref _lightIndex, value);
		}

		public gameuiPhotomodeSetActiveLightEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
