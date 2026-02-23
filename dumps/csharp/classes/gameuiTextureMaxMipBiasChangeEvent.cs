using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTextureMaxMipBiasChangeEvent : redEvent
	{
		private CUInt32 _textureMaxMipBias;

		[Ordinal(0)] 
		[RED("textureMaxMipBias")] 
		public CUInt32 TextureMaxMipBias
		{
			get => GetProperty(ref _textureMaxMipBias);
			set => SetProperty(ref _textureMaxMipBias, value);
		}

		public gameuiTextureMaxMipBiasChangeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
