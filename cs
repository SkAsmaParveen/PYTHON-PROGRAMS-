import numpy as np
a = np.array([[1,2,3,4],[5,6,7,9]])
print(type(a))
print(a.ndim)
print(np.shape(a))
b1 = np.reshape(a,(4,2))
print(b1)
b=np.array([[[1,2,3,4],[4,5,6,7]],[[1,2,43,44],[54,78,23,21]]])
print(b)
print(b.ndim)
print(np.shape(a))
b2=np.reshape(a,(4,2))
print(b2)


a=np.array([[1,2,3,4],[2,3,4,5]])
b=np.asarray(a,'float','F')
#numpy.asarray(sequence,  dtype = None, order = None)
print(type(b))
print(b)
for i in np.nditer(b):
    print(i)
    
    
a=np.array([[1,2,3,4],[3,4,5,5]])
print(a.ndim)
b=np.reshape(a,(4,2)) #here a is already created array
print(b)
c=np.arange(10)
c=c.reshape(2,5) #in the case of arrange function
print(c)
k=np.arange(0,20,5) #arange allows you to specify the size of the steps
print(k)
o=np.linspace(0,20,5) #linspace allows you to specify the number of steps
print(o)


n=np.array([[1,2,3,4],[2,3,54,5]])
print(n)
print(n[1,3])  #indexing starts from 0 to n-1 


print(np.zeros((2,3))) #it takes only one argument : shape of the matrix
print(np.ones((2,3)))
print(np.full(((2,3)),40)) # it takes 2 args : shape,the 'value' to be filled
print(np.full((2,3),34)) #it takes 2 args: shape,the 'value'



n=np.array([[1,2,4443,4],[2,3,54,5]])
print(n)
print(n[1,3])  #indexing starts from 0 to n-1 
n[-1,-1]
n[1:3]
a=np.sort(n,axis=0) #sort() : sorts normally ; sort(a,axis=0) column wise ; sort(a,axis=1) row wise
print(a)


a=np.arange(0,10).reshape(2,5)
print(a)
n=np.arange(10,20).reshape(2,5)
print(n)
np.concatenate((a,n),axis=0) 
print(np.min(a,axis=0))
