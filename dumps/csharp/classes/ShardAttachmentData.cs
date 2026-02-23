using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShardAttachmentData : IScriptable
	{
		private CInt32 _hash;

		[Ordinal(0)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		public ShardAttachmentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
