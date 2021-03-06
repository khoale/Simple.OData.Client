﻿using System;

namespace Simple.OData.Client
{
    public partial class ODataExpression
    {
        public static implicit operator ODataExpression(bool value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(byte value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(sbyte value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(short value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(ushort value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(int value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(uint value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(long value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(ulong value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(float value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(double value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(decimal value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(DateTime value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(DateTimeOffset value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(TimeSpan value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(Guid value) { return ODataExpression.FromValue(value); }
        public static implicit operator ODataExpression(string value) { return ODataExpression.FromValue(value); }

        public static ODataExpression operator !(ODataExpression expr)
        {
            return new ODataExpression(expr, null, ExpressionOperator.NOT);
        }

        public static ODataExpression operator -(ODataExpression expr)
        {
            return new ODataExpression(expr, null, ExpressionOperator.NEG);
        }

        public static ODataExpression operator ==(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.EQ);
        }

        public static ODataExpression operator !=(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.NE);
        }

        public static ODataExpression operator &(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.AND);
        }

        public static ODataExpression operator |(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.OR);
        }

        public static ODataExpression operator >(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.GT);
        }

        public static ODataExpression operator <(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.LT);
        }

        public static ODataExpression operator >=(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.GE);
        }

        public static ODataExpression operator <=(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.LE);
        }

        public static ODataExpression operator +(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.ADD);
        }

        public static ODataExpression operator -(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.SUB);
        }

        public static ODataExpression operator *(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.MUL);
        }

        public static ODataExpression operator /(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.DIV);
        }

        public static ODataExpression operator %(ODataExpression expr1, ODataExpression expr2)
        {
            return new ODataExpression(expr1, expr2, ExpressionOperator.MOD);
        }

        public static bool operator true(ODataExpression expr)
        {
            return false;
        }

        public static bool operator false(ODataExpression expr)
        {
            return false;
        }
    }
}