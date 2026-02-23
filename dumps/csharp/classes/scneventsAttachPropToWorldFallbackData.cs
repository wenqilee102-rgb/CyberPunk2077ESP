using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scneventsAttachPropToWorldFallbackData : CVariable
	{
		private scnPerformerId _owner;
		private CStatic<scneventsAttachPropToWorldCachedFallbackBone> _fallbackCachedBones;
		private rRef<animAnimSet> _fallbackAnimset;
		private CName _fallbackAnimationName;
		private CFloat _fallbackAnimTime;

		[Ordinal(0)] 
		[RED("owner")] 
		public scnPerformerId Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("fallbackCachedBones", 2)] 
		public CStatic<scneventsAttachPropToWorldCachedFallbackBone> FallbackCachedBones
		{
			get => GetProperty(ref _fallbackCachedBones);
			set => SetProperty(ref _fallbackCachedBones, value);
		}

		[Ordinal(2)] 
		[RED("fallbackAnimset")] 
		public rRef<animAnimSet> FallbackAnimset
		{
			get => GetProperty(ref _fallbackAnimset);
			set => SetProperty(ref _fallbackAnimset, value);
		}

		[Ordinal(3)] 
		[RED("fallbackAnimationName")] 
		public CName FallbackAnimationName
		{
			get => GetProperty(ref _fallbackAnimationName);
			set => SetProperty(ref _fallbackAnimationName, value);
		}

		[Ordinal(4)] 
		[RED("fallbackAnimTime")] 
		public CFloat FallbackAnimTime
		{
			get => GetProperty(ref _fallbackAnimTime);
			set => SetProperty(ref _fallbackAnimTime, value);
		}

		public scneventsAttachPropToWorldFallbackData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
