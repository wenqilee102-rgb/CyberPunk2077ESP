using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipAndTearEffector : ModifyDamageEffector
	{
		private CName _sfxName;
		private CName _vfxName;
		private CString _statusEffectToRemove;
		private EngineTime _prevCleanupTime;

		[Ordinal(6)] 
		[RED("sfxName")] 
		public CName SfxName
		{
			get => GetProperty(ref _sfxName);
			set => SetProperty(ref _sfxName, value);
		}

		[Ordinal(7)] 
		[RED("vfxName")] 
		public CName VfxName
		{
			get => GetProperty(ref _vfxName);
			set => SetProperty(ref _vfxName, value);
		}

		[Ordinal(8)] 
		[RED("statusEffectToRemove")] 
		public CString StatusEffectToRemove
		{
			get => GetProperty(ref _statusEffectToRemove);
			set => SetProperty(ref _statusEffectToRemove, value);
		}

		[Ordinal(9)] 
		[RED("prevCleanupTime")] 
		public EngineTime PrevCleanupTime
		{
			get => GetProperty(ref _prevCleanupTime);
			set => SetProperty(ref _prevCleanupTime, value);
		}

		public RipAndTearEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
