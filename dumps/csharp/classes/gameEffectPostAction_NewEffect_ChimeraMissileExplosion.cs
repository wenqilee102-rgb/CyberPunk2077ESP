using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectPostAction_NewEffect_ChimeraMissileExplosion : gameEffectPostAction
	{
		private CName _tagInThisFile;
		private CFloat _overrideRadius;
		private CInt32 _executeOnNthHit;

		[Ordinal(0)] 
		[RED("tagInThisFile")] 
		public CName TagInThisFile
		{
			get => GetProperty(ref _tagInThisFile);
			set => SetProperty(ref _tagInThisFile, value);
		}

		[Ordinal(1)] 
		[RED("overrideRadius")] 
		public CFloat OverrideRadius
		{
			get => GetProperty(ref _overrideRadius);
			set => SetProperty(ref _overrideRadius, value);
		}

		[Ordinal(2)] 
		[RED("executeOnNthHit")] 
		public CInt32 ExecuteOnNthHit
		{
			get => GetProperty(ref _executeOnNthHit);
			set => SetProperty(ref _executeOnNthHit, value);
		}

		public gameEffectPostAction_NewEffect_ChimeraMissileExplosion(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
