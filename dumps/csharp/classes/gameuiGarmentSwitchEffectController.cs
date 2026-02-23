using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGarmentSwitchEffectController : CVariable
	{
		private CName _sceneName;
		private CName _effectName;
		private CFloat _switchTime;
		private CFloat _hideTime;

		[Ordinal(0)] 
		[RED("sceneName")] 
		public CName SceneName
		{
			get => GetProperty(ref _sceneName);
			set => SetProperty(ref _sceneName, value);
		}

		[Ordinal(1)] 
		[RED("effectName")] 
		public CName EffectName
		{
			get => GetProperty(ref _effectName);
			set => SetProperty(ref _effectName, value);
		}

		[Ordinal(2)] 
		[RED("switchTime")] 
		public CFloat SwitchTime
		{
			get => GetProperty(ref _switchTime);
			set => SetProperty(ref _switchTime, value);
		}

		[Ordinal(3)] 
		[RED("hideTime")] 
		public CFloat HideTime
		{
			get => GetProperty(ref _hideTime);
			set => SetProperty(ref _hideTime, value);
		}

		public gameuiGarmentSwitchEffectController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
