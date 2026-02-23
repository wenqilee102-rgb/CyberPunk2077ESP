using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_BeamVFX_Custom : gameEffectPostAction_BeamVFX
	{
		private raRef<worldEffect> _effect;
		private CBool _attached;
		private CBool _breakLoopOnDetach;
		private CBool _invert;
		private CFloat _maxRange;
		private CFloat _maxRangeTPP;
		private CName _effectTag;

		[Ordinal(0)] 
		[RED("effect")] 
		public raRef<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(1)] 
		[RED("attached")] 
		public CBool Attached
		{
			get => GetProperty(ref _attached);
			set => SetProperty(ref _attached, value);
		}

		[Ordinal(2)] 
		[RED("breakLoopOnDetach")] 
		public CBool BreakLoopOnDetach
		{
			get => GetProperty(ref _breakLoopOnDetach);
			set => SetProperty(ref _breakLoopOnDetach, value);
		}

		[Ordinal(3)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetProperty(ref _invert);
			set => SetProperty(ref _invert, value);
		}

		[Ordinal(4)] 
		[RED("maxRange")] 
		public CFloat MaxRange
		{
			get => GetProperty(ref _maxRange);
			set => SetProperty(ref _maxRange, value);
		}

		[Ordinal(5)] 
		[RED("maxRangeTPP")] 
		public CFloat MaxRangeTPP
		{
			get => GetProperty(ref _maxRangeTPP);
			set => SetProperty(ref _maxRangeTPP, value);
		}

		[Ordinal(6)] 
		[RED("effectTag")] 
		public CName EffectTag
		{
			get => GetProperty(ref _effectTag);
			set => SetProperty(ref _effectTag, value);
		}

		public gameEffectPostAction_BeamVFX_Custom(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
