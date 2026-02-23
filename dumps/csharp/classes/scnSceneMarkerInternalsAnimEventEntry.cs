using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneMarkerInternalsAnimEventEntry : CVariable
	{
		private CName _startName;
		private CName _endName;
		private Vector3 _startPos;
		private Vector3 _endPos;
		private Vector3 _startDir;
		private Vector3 _endDir;
		private CUInt8 _flags;

		[Ordinal(0)] 
		[RED("startName")] 
		public CName StartName
		{
			get => GetProperty(ref _startName);
			set => SetProperty(ref _startName, value);
		}

		[Ordinal(1)] 
		[RED("endName")] 
		public CName EndName
		{
			get => GetProperty(ref _endName);
			set => SetProperty(ref _endName, value);
		}

		[Ordinal(2)] 
		[RED("startPos")] 
		public Vector3 StartPos
		{
			get => GetProperty(ref _startPos);
			set => SetProperty(ref _startPos, value);
		}

		[Ordinal(3)] 
		[RED("endPos")] 
		public Vector3 EndPos
		{
			get => GetProperty(ref _endPos);
			set => SetProperty(ref _endPos, value);
		}

		[Ordinal(4)] 
		[RED("startDir")] 
		public Vector3 StartDir
		{
			get => GetProperty(ref _startDir);
			set => SetProperty(ref _startDir, value);
		}

		[Ordinal(5)] 
		[RED("endDir")] 
		public Vector3 EndDir
		{
			get => GetProperty(ref _endDir);
			set => SetProperty(ref _endDir, value);
		}

		[Ordinal(6)] 
		[RED("flags")] 
		public CUInt8 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		public scnSceneMarkerInternalsAnimEventEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
