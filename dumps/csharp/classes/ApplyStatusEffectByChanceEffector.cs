using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyStatusEffectByChanceEffector : gameEffector
	{
		private entEntityID _targetEntityID;
		private CName _applicationTarget;
		private TweakDBID _record;
		private CBool _removeWithEffector;
		private CArray<wCHandle<gamedataStatModifier_Record>> _effectorChanceMods;

		[Ordinal(0)] 
		[RED("targetEntityID")] 
		public entEntityID TargetEntityID
		{
			get => GetProperty(ref _targetEntityID);
			set => SetProperty(ref _targetEntityID, value);
		}

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetProperty(ref _applicationTarget);
			set => SetProperty(ref _applicationTarget, value);
		}

		[Ordinal(2)] 
		[RED("record")] 
		public TweakDBID Record
		{
			get => GetProperty(ref _record);
			set => SetProperty(ref _record, value);
		}

		[Ordinal(3)] 
		[RED("removeWithEffector")] 
		public CBool RemoveWithEffector
		{
			get => GetProperty(ref _removeWithEffector);
			set => SetProperty(ref _removeWithEffector, value);
		}

		[Ordinal(4)] 
		[RED("effectorChanceMods")] 
		public CArray<wCHandle<gamedataStatModifier_Record>> EffectorChanceMods
		{
			get => GetProperty(ref _effectorChanceMods);
			set => SetProperty(ref _effectorChanceMods, value);
		}

		public ApplyStatusEffectByChanceEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
