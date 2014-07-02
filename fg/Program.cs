//
//  Program.cs
//
//  Author:
//       student <>
//
//  Copyright (c) 2014 student
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System;

namespace fg
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Программа предназначена для расчёта произведения двух чисел");
			Console.WriteLine ("-------------------------------------------------------------");
			Console.WriteLine ("Введите значение переменной V1");
			int v1 = int.Parse(Console.ReadLine());
			Console.WriteLine ("------------------------------------");
			Console.WriteLine ("Введите значение переменной V2");
			int v2 = int.Parse(Console.ReadLine());
			int vv;

			vv = v1 * v2;
			Console.WriteLine ("------------------------------------");
			Console.WriteLine ("Произведение {0} и {1} равно {2}",v1, v2, vv);
		}
	}
}
