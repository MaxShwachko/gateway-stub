using System;
using System.Collections.Generic;
using System.Text;
using GatewayStub.ByteFormatter.StateSerialize;

namespace GatewayStub.ByteFormatter
{
	[ByteExtension]
	public sealed class ByteReader : ICloneable
	{
		private readonly ByteBuffer _buffer;

		public ByteReader()
		{
			_buffer = new ByteBuffer();
		}

		public ByteReader(byte[] buffer)
		{
			_buffer = new ByteBuffer(buffer);
		}

		private ByteReader(ByteBuffer buffer)
		{
			_buffer = buffer;
		}

		public long Position => _buffer.Position;

		public int Length => _buffer.Length;

		public void ReInit(byte[] bytes) => _buffer.ReInit(bytes);
		
		public void Reset() => _buffer.Reset();
		
		public void SeekZero() => _buffer.SeekZero();

		public void Skip(uint length) => _buffer.Skip(length);

		public void Replace(byte[] buffer) => _buffer.Replace(buffer);

		public byte ReadByte() => _buffer.ReadByte();

		public void SkipByte() => _buffer.Skip(1U);

		public byte? ReadByteNullable() => ReadBoolean() ? ReadByte() : null as byte?;

		public void SkipByteNullable()
		{
			if (ReadBoolean())
				_buffer.Skip(1U);
		}

		public sbyte ReadSByte() => (sbyte)_buffer.ReadByte();

		public void SkipSByte() => _buffer.Skip(1U);

		public sbyte? ReadSByteNullable() => ReadBoolean() ? ReadSByte() : null as sbyte?;

		public void SkipSByteNullable()
		{
			if (ReadBoolean())
				_buffer.Skip(1U);
		}

		public short ReadInt16()
			=> (short)(ushort)((ushort)(0U | _buffer.ReadByte()) |
			                   (uint)(ushort)((uint)_buffer.ReadByte() << 8));

		public void SkipInt16() => _buffer.Skip(2U);

		public short? ReadInt16Nullable() => ReadBoolean() ? ReadInt16() : null as short?;

		public void SkipInt16Nullable()
		{
			if (ReadBoolean())
				_buffer.Skip(2U);
		}

		public ushort ReadUInt16()
			=> (ushort)((ushort)(0U | _buffer.ReadByte()) |
			            (uint)(ushort)((uint)_buffer.ReadByte() << 8));

		public void SkipUInt16() => _buffer.Skip(2U);

		public ushort? ReadUInt16Nullable() => ReadBoolean() ? ReadUInt16() : null as ushort?;

		public void SkipUInt16Nullable()
		{
			if (ReadBoolean())
				_buffer.Skip(2U);
		}

		public int ReadInt32()
			=> (int)(0U | _buffer.ReadByte() | ((uint)_buffer.ReadByte() << 8) |
			         ((uint)_buffer.ReadByte() << 16) | ((uint)_buffer.ReadByte() << 24));

		public void SkipInt32() => _buffer.Skip(4U);

		public uint ReadUInt32()
			=> 0U | _buffer.ReadByte() | ((uint)_buffer.ReadByte() << 8) |
			   ((uint)_buffer.ReadByte() << 16) | ((uint)_buffer.ReadByte() << 24);

		public void SkipUInt32() => _buffer.Skip(4U);

		public uint? ReadUInt32Nullable() => ReadBoolean() ? ReadUInt32() : null as uint?;

		public void SkipUInt32Nullable()
		{
			if (ReadBoolean())
				_buffer.Skip(4U);
		}

		public long ReadInt64()
			=> (long)(0UL | _buffer.ReadByte() | ((ulong)_buffer.ReadByte() << 8) |
			          ((ulong)_buffer.ReadByte() << 16) | ((ulong)_buffer.ReadByte() << 24) |
			          ((ulong)_buffer.ReadByte() << 32) | ((ulong)_buffer.ReadByte() << 40) |
			          ((ulong)_buffer.ReadByte() << 48) | ((ulong)_buffer.ReadByte() << 56));

		public void SkipInt64() => _buffer.Skip(8U);

		public long? ReadInt64Nullable()
			=> ReadBoolean() ? ReadInt64() : null as long?;

		public void SkipInt64Nullable()
		{
			if (ReadBoolean())
				_buffer.Skip(8U);
		}

		public ulong ReadUInt64()
			=> 0UL | _buffer.ReadByte() | ((ulong)_buffer.ReadByte() << 8) |
			   ((ulong)_buffer.ReadByte() << 16) | ((ulong)_buffer.ReadByte() << 24) |
			   ((ulong)_buffer.ReadByte() << 32) | ((ulong)_buffer.ReadByte() << 40) |
			   ((ulong)_buffer.ReadByte() << 48) | ((ulong)_buffer.ReadByte() << 56);


		public void SkipUInt64() => _buffer.Skip(8U);

		public ulong? ReadUInt64Nullable()
			=> ReadBoolean() ? ReadUInt64() : null as ulong?;

		public void SkipUInt64Nullable()
		{
			if (ReadBoolean())
				_buffer.Skip(8U);
		}

		public decimal ReadDecimal()
			=> new decimal(new int[4]
			{
				ReadInt32(),
				ReadInt32(),
				ReadInt32(),
				ReadInt32()
			});

		public void SkipDecimal() => _buffer.Skip(16U);

		public float ReadSingle()
		{
			var intVal = ReadInt32();
			return BitConverter.ToSingle(BitConverter.GetBytes(intVal), 0);
		}

		public void SkipSingle() => _buffer.Skip(4U);

		public float? ReadSingleNullable()
		{
			var hasValue = ReadBoolean();
			return hasValue ? ReadSingle() : null as float?;
		}

		public void SkipSingleNullable()
		{
			if (ReadBoolean())
				_buffer.Skip(4U);
		}

		public double ReadDouble()
		{
			var longVal = ReadInt64();
			return BitConverter.Int64BitsToDouble(longVal);
		}

		public void SkipDouble() => _buffer.Skip(8U);

		public char ReadChar() => (char)_buffer.ReadByte();

		public void SkipChar() => _buffer.Skip(1U);

		public bool ReadBoolean() => _buffer.ReadByte() == 1;

		public void SkipBoolean() => _buffer.Skip(1U);

		public byte[] ReadBytes(int count)
		{
			if (count < 0)
				throw new IndexOutOfRangeException("NetworkReader ReadBytes " + count);
			var buffer = new byte[count];
			_buffer.ReadBytes(buffer, (uint)count);
			return buffer;
		}

		public byte[] ReadBytesAndSize()
		{
			var num = ReadInt32();
			return num == 0 ? Array.Empty<byte>() : ReadBytes(num);
		}

		public void SkipBytesAndSize()
		{
			var length = ReadInt32();
			_buffer.Skip((uint)length);
		}

		public string ReadString()
		{
			var bytes = ReadBytesAndSize();
			return Encoding.UTF8.GetString(bytes);
		}

		public void SkipString() => SkipBytesAndSize();

		public int? ReadInt32Nullable()
		{
			var hasValue = ReadBoolean();
			return hasValue ? ReadInt32() : null as int?;
		}

		public void SkipInt32Nullable()
		{
			if (ReadBoolean())
				_buffer.Skip(4U);
		}

		public int[] ReadInt32Array()
		{
			var lenght = ReadInt32();
			var array = new int[lenght];
			for (var i = 0; i < lenght; i++)
			{
				array[i] = ReadInt32();
			}

			return array;
		}

		public void SkipInt32Array()
		{
			var length = ReadInt32();
			_buffer.Skip((uint)length * 4U);
		}

		public int?[] ReadInt32NullableArray()
		{
			var lenght = ReadInt32();
			var array = new int?[lenght];
			for (var i = 0; i < lenght; i++)
			{
				array[i] = ReadInt32Nullable();
			}

			return array;
		}

		public void SkipInt32NullableArray()
		{
			var lenght = ReadInt32();
			for (var i = 0; i < lenght; i++)
			{
				SkipInt32Nullable();
			}
		}

		public float[] ReadSingleArray()
		{
			var lenght = ReadInt32();
			var array = new float[lenght];
			for (var i = 0; i < lenght; i++)
			{
				array[i] = ReadSingle();
			}

			return array;
		}

		public void SkipSingleArray()
		{
			var length = ReadInt32();
			_buffer.Skip((uint)length * 4U);
		}

		public float?[] ReadSingleNullableArray()
		{
			var lenght = ReadInt32();
			var array = new float?[lenght];
			for (var i = 0; i < lenght; i++)
			{
				array[i] = ReadSingleNullable();
			}

			return array;
		}

		public void SkipSingleNullableArray()
		{
			var lenght = ReadInt32();
			for (var i = 0; i < lenght; i++)
			{
				SkipSingleNullable();
			}
		}

		public string[] ReadStringArray()
		{
			var lenght = ReadInt32();
			var array = new string[lenght];
			for (var i = 0; i < lenght; i++)
			{
				array[i] = ReadString();
			}

			return array;
		}

		public List<T> ReadList<T>()
			where T : IByteConvertable, new()
		{
			var count = ReadInt32();
			var list = new List<T>(count);
			for (var i = 0; i < count; i++)
			{
				var convertable = new T();
				convertable.FromByte(this);
				list.Add(convertable);
			}

			return list;
		}

		public T[] ReadArray<T>()
			where T : IByteConvertable, new()
		{
			var count = ReadInt32();
			var list = new T[count];
			for (var i = 0; i < count; i++)
			{
				var convertable = new T();
				convertable.FromByte(this);
				list[i] = convertable;
			}

			return list;
		}

		public void SkipMatrix4x4() => _buffer.Skip(64U);

		public override string ToString() => _buffer.ToString();

		public T Read<T>() where T : IByteConvertable, new()
		{
			var convertable = new T();
			convertable.FromByte(this);
			return convertable;
		}

		object ICloneable.Clone() => Clone();

		public ByteReader Clone() => new ByteReader(_buffer.Clone());
	}
}