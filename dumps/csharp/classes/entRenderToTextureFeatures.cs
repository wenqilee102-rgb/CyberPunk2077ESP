using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entRenderToTextureFeatures : CVariable
	{
		private CBool _renderDecals;
		private CBool _renderParticles;
		private CBool _renderForwardNoTXAA;
		private CEnum<entRenderToTextureFeaturesPlatform> _antiAliasing;
		private CBool _contactShadows;
		private CBool _localShadows;
		private CEnum<entRenderToTextureFeaturesPlatform> _sSAO;
		private CEnum<entRenderToTextureFeaturesPlatform> _reflections;

		[Ordinal(0)] 
		[RED("renderDecals")] 
		public CBool RenderDecals
		{
			get => GetProperty(ref _renderDecals);
			set => SetProperty(ref _renderDecals, value);
		}

		[Ordinal(1)] 
		[RED("renderParticles")] 
		public CBool RenderParticles
		{
			get => GetProperty(ref _renderParticles);
			set => SetProperty(ref _renderParticles, value);
		}

		[Ordinal(2)] 
		[RED("renderForwardNoTXAA")] 
		public CBool RenderForwardNoTXAA
		{
			get => GetProperty(ref _renderForwardNoTXAA);
			set => SetProperty(ref _renderForwardNoTXAA, value);
		}

		[Ordinal(3)] 
		[RED("antiAliasing")] 
		public CEnum<entRenderToTextureFeaturesPlatform> AntiAliasing
		{
			get => GetProperty(ref _antiAliasing);
			set => SetProperty(ref _antiAliasing, value);
		}

		[Ordinal(4)] 
		[RED("contactShadows")] 
		public CBool ContactShadows
		{
			get => GetProperty(ref _contactShadows);
			set => SetProperty(ref _contactShadows, value);
		}

		[Ordinal(5)] 
		[RED("localShadows")] 
		public CBool LocalShadows
		{
			get => GetProperty(ref _localShadows);
			set => SetProperty(ref _localShadows, value);
		}

		[Ordinal(6)] 
		[RED("SSAO")] 
		public CEnum<entRenderToTextureFeaturesPlatform> SSAO
		{
			get => GetProperty(ref _sSAO);
			set => SetProperty(ref _sSAO, value);
		}

		[Ordinal(7)] 
		[RED("reflections")] 
		public CEnum<entRenderToTextureFeaturesPlatform> Reflections
		{
			get => GetProperty(ref _reflections);
			set => SetProperty(ref _reflections, value);
		}

		public entRenderToTextureFeatures(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
