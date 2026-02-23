using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTextureMinMipBiasChangeEvent : redEvent
	{
		private CUInt32 _textureMinMipBias;

		[Ordinal(0)] 
		[RED("textureMinMipBias")] 
		public CUInt32 TextureMinMipBias
		{
			get => GetProperty(ref _textureMinMipBias);
			set => SetProperty(ref _textureMinMipBias, value);
		}

		public gameuiTextureMinMipBiasChangeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
