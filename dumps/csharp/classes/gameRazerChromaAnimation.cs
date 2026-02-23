using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameRazerChromaAnimation : CVariable
	{
		private CInt32 _id;
		private CName _name;
		private DataBuffer _buffer;

		[Ordinal(0)] 
		[RED("id")] 
		public CInt32 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(2)] 
		[RED("buffer")] 
		public DataBuffer Buffer
		{
			get => GetProperty(ref _buffer);
			set => SetProperty(ref _buffer, value);
		}

		public gameRazerChromaAnimation(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
