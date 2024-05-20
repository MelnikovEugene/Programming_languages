s = 12
p = 27
for X in range(1, 1001):
    Y = s - X
    if Y >= 1 and Y <= 1000 and X * Y == p:
        if X <= Y:
            print(X, Y)