using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    abstract class Animal
    {
        private string _name;
        protected int _level;
        protected COLOR _color;


        public string Name { get { return _name; } }
        public int Level { get { return _level; } }
        public COLOR Color { get { return _color; } }



        public Animal ( string name, COLOR color )
        {
            _name = name;
            _color = color;

        }
        //Object 클래스의 ToString() 을 override한다.
        public override string ToString ()
        {
            return $"ANIMAL:{_name}";
        }

        // 추상메소드 : 메소드의 기본 틀만 제공하고 내용은 자식에서 구현한다.

        abstract protected bool AddLevel ( int level );
       /* {
            if ( _level + level <= 100 )
            {
                _level += level;
                return true;
            }
            else
            {
                _level = 100;
                return false;
            }
        }*/
        // 가상 메소드로 만들어 override가 가능하게 함.
        public virtual void Eat ()
        {
            AddLevel (3);
        }
        public void Play ()
        {
            AddLevel (2);
        }
    }
}
