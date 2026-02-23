using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleOnTurnOnPlayEffectDevice : Device
	{
		private CName _onTurnOnEffectName;
		private CName _onTurnOffEffectName;

		[Ordinal(88)] 
		[RED("OnTurnOnEffectName")] 
		public CName OnTurnOnEffectName
		{
			get => GetProperty(ref _onTurnOnEffectName);
			set => SetProperty(ref _onTurnOnEffectName, value);
		}

		[Ordinal(89)] 
		[RED("OnTurnOffEffectName")] 
		public CName OnTurnOffEffectName
		{
			get => GetProperty(ref _onTurnOffEffectName);
			set => SetProperty(ref _onTurnOffEffectName, value);
		}

		public SimpleOnTurnOnPlayEffectDevice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
