using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    /* whate you can wite inside namespace 
    1.classes 
    2.struct 
    3.interface
    4.enum         
    
    allowed access modifers inside namespace
    1. internal (defaulte access modifer)
    2. public

    default access modifer inside class and struct 
    [private]
    */
    internal class typeA
    {
        /*whate i can write insade class or instract
         * attrubutes
         * function[constructor , getter ,setter ,methods]
         * properties [ full property , autmatic property ,index]
         */
        /*whate i can write insade  interface
         * signatture for methods
         * signatture for property
         * default implement method c# 8
         */
        /* allowed access modifer inside class 
         * private 
         * private protected
         * protected
         * internal
         * internal protected
         * public
        */
        /* allowed access modifer inside instract         
         * private 
         * internal
         * public
        */
        private int x; // inside this class only 
        private protected int y; // inhrited classes from this class in the same project
        protected int z; // inside  inhrited classes from this class in any project
        internal protected int w; // accessable in this projct   and inside  inhrited classes from this class in any project
        internal int h; // accessable in this projct only 
        public int r; //in any location

    }
}
