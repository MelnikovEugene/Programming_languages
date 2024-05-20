coins = [0, 1, 0, 1, 1, 0]
count_heads = 0
count_tails = 0
for coin in coins:
    if coin == 0:
        count_heads += 1
    else:
        count_tails += 1
min_flips = count_heads if count_heads < count_tails else count_tails
print(min_flips)