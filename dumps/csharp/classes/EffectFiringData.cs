using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EffectFiringData : CVariable
	{
		private CFloat _fXTime;
		private CName _vFX;
		private CName _sFX;

		[Ordinal(0)] 
		[RED("FXTime")] 
		public CFloat FXTime
		{
			get => GetProperty(ref _fXTime);
			set => SetProperty(ref _fXTime, value);
		}

		[Ordinal(1)] 
		[RED("VFX")] 
		public CName VFX
		{
			get => GetProperty(ref _vFX);
			set => SetProperty(ref _vFX, value);
		}

		[Ordinal(2)] 
		[RED("SFX")] 
		public CName SFX
		{
			get => GetProperty(ref _sFX);
			set => SetProperty(ref _sFX, value);
		}

		public EffectFiringData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
